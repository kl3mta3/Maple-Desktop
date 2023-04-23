using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Net;
using YoutubeExplode.Videos.Streams;
using System.IO;
using VideoLibrary;
using YoutubeExplode.Search;
using System.Windows;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace MapleHome
{
    public class MusicSystem
    {
        private List<string> searchResults = new List<string>();
        private List <VideoSearchResult> searchResults1 = new List<VideoSearchResult>();
        //internal Dictionary<int, Song> playlist = new Dictionary<int, Song>();
        internal static List<Song> playlist = new List<Song>();
        internal List<Video> videoPlaylist = new List<Video>();
        internal int currentTrackPlaylistId = 0;
        internal int currentVideoPlaylistId = 0;
        internal int playlistCount = 0;
        
        internal Song? currentTrack= new Song();

        internal Song urlDownloadResults=new Song();
        internal bool playingTrack = false;
        internal bool trackPaused = false;

        internal int currentVideoNumber = 0;
        internal int videoPlaylistCount = 0;
        internal Video? currentVideo = null;
        internal bool playingVideo = false;
        internal bool videoPaused = false;
        internal bool userPressedNext = false;
        internal bool userPressedStop = false;
        internal bool userpressedSeek = false;
        internal bool userPressedLast = false;
        internal bool keepCurrentTrack=false;
        internal int currentTrackCurrentTime;
        internal int progressBarCurrentTime;
        private static string numberPattern = " ({0})";
        internal static bool saveMusic = false;
        public string? currentTrackProgress   { get; set; } = "0:00/0:00";
        public string? currentTrackProgressstar { get; set; }= "0:00";


        internal void HandleRequest(string request, object sender, EventArgs e)
        {

            PlaySearchRequest(request,sender,e);

        }
        internal async Task PlaySearchRequest(string request, object sender, EventArgs e)
        {
           Helpers helper  =new Helpers();
            MapleHome.debugConsole.WriteToDebugConsole($"Sent Request for '{request}'");
            await AddFileToPlaylist(request);
           

            if(MapleHome.playAudio)
            {
                //Song song = new Song();
               // MapleHome.debugConsole.WriteToDebugConsole($"Starting Player");
                if(playingTrack)
                {
                    return;
                }
                if (currentTrack == null)
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"Current Track is Empty looking for Track");
                    MapleHome.debugConsole.WriteToDebugConsole($"currentTrackId is {currentTrackPlaylistId}");
                    int nextTrackNumber = currentTrackPlaylistId + 1;
                    MapleHome.debugConsole.WriteToDebugConsole($"NexyTrackID is {nextTrackNumber}");

                    foreach (Song track in playlist)
                    {
                      
                        if (track.playlistId == nextTrackNumber)
                        {
                            
                            currentTrack = track;
                            currentTrackPlaylistId = track.playlistId;
                            MapleHome.debugConsole.WriteToDebugConsole($"Track Found {track.title}");
                            break;
                        }

                    }

                }
                else if (currentTrack != null)
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"Next Track exists  is {currentTrack.title}");

                    int nextTrackNumber = currentTrackPlaylistId + 1;
                    MapleHome.debugConsole.WriteToDebugConsole($"NexyTrackNumber is {nextTrackNumber}");

                    foreach (Song track in playlist)
                    {
                        
                        if (track.playlistId == nextTrackNumber)
                        {

                            currentTrack = track;
                            currentTrackPlaylistId = track.playlistId;
                            MapleHome.debugConsole.WriteToDebugConsole($"Next Track Found {track.title}");
                            break;
                        }

                    }



                }

                //helper.WriteToMapleConsole($"Building Player Info");


                MapleHome.debugConsole.WriteToDebugConsole($"currentTrack path = {currentTrack.path}");
                MapleHome.debugConsole.WriteToDebugConsole($"starting Track");
                MapleHome.debugConsole.WriteToDebugConsole($"song title ={currentTrack.title}");
                MapleHome.debugConsole.WriteToDebugConsole($"song Artist= {currentTrack.author}");
                MapleHome.debugConsole.WriteToDebugConsole($"song length = {currentTrack.length}");
                MapleHome.debugConsole.WriteToDebugConsole($"song url = {currentTrack.url}");
                MapleHome.debugConsole.WriteToDebugConsole($"Audio Playback Request Sent");

                currentTrackPlaylistId=currentTrack.playlistId;
                PlaySong(currentTrack.path, sender, e);
            }
            if (MapleHome.playVideo)
            {
                Video video = new Video();
              //  helper.WriteToMapleConsole($"Video playback Triggered");

                if (currentVideo == null)
                {
                    //helper.WriteToMapleConsole($"Current Track is Empty looking for Track");
                    // helper.WriteToMapleConsole($"currentTrackNumber is {currentTrackNumber}");
                    int nextVideoNumber = currentVideoPlaylistId + 1;
                    //helper.WriteToMapleConsole($"NexyTrackNumber is {nextTrackNumber}");

                  
                    foreach (Video track in videoPlaylist)
                    {

                        if (track.playlistId == nextVideoNumber)
                        {

                            currentVideo = track;
                            currentVideoPlaylistId = currentVideo.playlistId;
                            // helper.WriteToMapleConsole($"Video Found {currentVideo.title}");
                            break;
                        }

                    }





                }
                else if (currentVideo != null)
                {

                   // MapleHome.form.WriteToMapleConsole($"Next Video exists  is {video.title}");

                    int nextVideoNumber = currentVideo.playlistId;
                    currentVideoNumber =currentVideo.playlistId;
                    //helper.WriteToMapleConsole($"NexyTrackNumber is {nextTrackNumber}");

                    foreach (Video track in videoPlaylist)
                    {

                        if (track.playlistId == nextVideoNumber)
                        {

                            currentVideo = track;
                            currentVideoPlaylistId = currentVideo.playlistId;
                           // helper.WriteToMapleConsole($"Next Video Found {track.title}");
                            break;
                        }

                    }



                }


                   // helper.DisplayCurrentSongInfo(currentTrack.title, currentTrack.author, currentTrack.length, currentTrack.url);
                   // helper.WriteToMapleConsole($"Video Playback Request Sent with path {video.path}");
                //PlayVideo(currentVideo.path, sender, e); //use once video is understood more. 
                PlayVideo(currentVideo.url, sender, e);
            }
           // helper.WriteToMapleConsole($"PlayerFinished");



        }
        private void PlaySong(string filePath, object sender, EventArgs e)
        {

                MapleHome.debugConsole.WriteToDebugConsole($"Audio Playback Request Recieved for {filePath}");

            //helper.DisplayCurrentSongInfo(currentTrack.title, currentTrack.author, currentTrack.url);
            MapleHome.musicForm.DisplayCurrentSongInfo(currentTrack.title, currentTrack.author, currentTrack.url, currentTrack.playlistId.ToString()) ;

            string songLength = currentTrack.length;
            int tracklength= 0;
            string currentprogress = $"0:00/{currentTrack.length}";

            //helper.SetProgressBarCurrentTrackLength(songLength);
            MapleHome.musicForm.SetProgressBarCurrentTrackLength(songLength);
            //helper.SetProgressBarCurrentProgress(currentprogress);
            MapleHome.musicForm.SetProgressBarCurrentProgress(currentprogress);

            MapleHome.debugConsole.WriteToDebugConsole($"Beging playback for {filePath} request sent");
            MapleHome.musicForm.BeginPlayback(filePath);
            
        }



        internal void DeleteNonSavedFiles()
        {
            MapleHome.debugConsole.WriteToDebugConsole($"File Deletion entered with playlist size {playlist.Count}");
            foreach (Song song in playlist)
            {
                MapleHome.debugConsole.WriteToDebugConsole($"title -{song.title}");
                if (!song.keepFile)
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"keepFile -{song.keepFile}");
                    try
                    {
                        File.Delete(song.path);
                        MapleHome.debugConsole.WriteToDebugConsole($"File Removed");
                    }
                    catch (Exception ex)
                    {
                        MapleHome.debugConsole.WriteToDebugConsole("File Delete Failed " + ex.Message);
                    }
                }
               
            }

        }



            private void PlayVideo(string filePath, object sender, EventArgs e)
        {


            Helpers helper = new Helpers();
          //  helper.WriteToMapleConsole($"Video Playback Request Recieved");

          //  helper.WriteToMapleConsole("Video Begin Playback Triggered");
           // helper.WriteToMapleConsole($" file path {filePath}");

            ///use once video playbave is more understood. 
            MapleHome.videoPlayer.videoPath = filePath;
            MapleHome.videoPlayer.playVideo = true;
            ///

            MapleHome.videoPlayer.Show();
            MapleHome.videoPlayer.PlayVideo();
           // helper.WriteToMapleConsole("Video Playback Started");
            //MapleHome.form.BeginVideoPlayback(filePath);
        }

        internal Song SongFromUrl(string url)
        {
            Song song = new Song();
            DownloadAudioFromURL(url);

            song = urlDownloadResults;
            MapleHome.debugConsole.WriteToDebugConsole($"Song {song.title} returned from url {url}");
            return song;


        }

        internal async Task DownloadAudioFromURL(string url)
        {
            string result = url;
            MapleHome.debugConsole.WriteToDebugConsole($"Search Results= {result}");
            if (result == null)
            {

                MapleHome.debugConsole.WriteToDebugConsole("Error: Search Results Empty");
                return;

            }
            var youtube = MapleHome.youtube;
            var videoTitle = "";
            var videoAuthor = "";
            var videoDuration = "";
            var videoDataUrl = "";
            var videoUrl = result;
            var videoData = await youtube.Videos.GetAsync(videoUrl);
            string fileName = "";
            string musicFolder = "";
            string allegedPath = "";
            string allegedVideoPath = "";
            string filepath = "";
            string videoFilePath = "";
            // string path = "";
            bool keepfile = false;
           // MapleHome.debugConsole.WriteToDebugConsole($"Extracting MetaData");

            videoTitle = videoData.Title;
            videoAuthor = videoData.Author.ChannelTitle;
            videoDuration = videoData.Duration.ToString();
            videoDataUrl = videoData.Url;
            MapleHome.debugConsole.WriteToDebugConsole($"Getting Audio Manifest for {videoTitle}");
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            MapleHome.debugConsole.WriteToDebugConsole($"getting AudioStream");
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            MapleHome.debugConsole.WriteToDebugConsole($"Creating Audio Path");
            fileName = $"{videoData.Title} by {videoData.Author.ChannelTitle} ";
            musicFolder = MapleHome.musicSavePath;
            allegedPath = System.IO.Path.Combine(musicFolder, $"{fileName}.{streamInfo.Container}");

            //filepath = NextAvailableFilename(allegedPath);

            if (!File.Exists(allegedPath))
            {
                MapleHome.debugConsole.WriteToDebugConsole($"Downloading Audio File");

                await youtube.Videos.Streams.DownloadAsync(streamInfo, allegedPath);

                if (saveMusic)
                {

                    keepfile = true;
                }
                else
                {
                    keepfile = false;

                }
                MapleHome.debugConsole.WriteToDebugConsole($"Audio File Download Done");

            }
            else
            {
                keepfile = true;
                MapleHome.debugConsole.WriteToDebugConsole($"Audio File Already Exists");
            }

            Song song = new Song();
            song.author = videoAuthor;
            song.title = videoTitle;
            song.length = videoDuration;
            song.url = videoDataUrl;
            song.path = allegedPath;
            song.keepFile = keepfile;

            urlDownloadResults= song;
        }
        private async Task AddFileToPlaylist(string request)
        {
            //Helpers helper = new Helpers();
            //searchResults.Clear();
            await SearchForVideo(request);
            string result = searchResults1[0].Url;
            MapleHome.debugConsole.WriteToDebugConsole($"Search Results= {searchResults1[0]}");
            if (result == null)
            {

                MapleHome.debugConsole.WriteToDebugConsole("Error: Search Results Empty");
                return;

            }
            var youtube = MapleHome.youtube;
            var videoTitle = "";
            var videoAuthor = "";
            var videoDuration = "";
            var videoDataUrl = "";
            var videoUrl = searchResults1[0].Url;
            MapleHome.debugConsole.WriteToDebugConsole($"videoUrl {videoUrl}");
            var videoData = searchResults1[0];
            string fileName = "";
            string musicFolder = "";
            string allegedPath = "";
            string allegedVideoPath = "";
            string filepath = "";
            string videoFilePath = "";
            // string path = "";
            bool keepfile = false;
            MapleHome.debugConsole.WriteToDebugConsole($"Extracting MetaData");

            if (MapleHome.playAudio || MapleHome.saveMusic)
            {

                //var videoData = await youtube.Videos.GetAsync(videoUrl);

                videoTitle = videoData.Title;
                videoAuthor = videoData.Author.ChannelTitle;
                videoDuration = videoData.Duration.ToString();
                videoDataUrl = videoData.Url;
                MapleHome.debugConsole.WriteToDebugConsole($"Getting Audio Manifest for {videoTitle}");
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
                MapleHome.debugConsole.WriteToDebugConsole($"getting AudioStream");
                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                MapleHome.debugConsole.WriteToDebugConsole($"Creating Audio Path");


                fileName = $"{videoData.Title} by {videoData.Author.ChannelTitle} ";
                musicFolder = MapleHome.musicSavePath;
                allegedPath = Path.Combine(musicFolder, $"{fileName}.{streamInfo.Container}");
                MapleHome.debugConsole.WriteToDebugConsole($"Created Path  {allegedPath}");
                //filepath = NextAvailableFilename(allegedPath);

                if (!File.Exists(allegedPath))
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"Downloading Audio File");

                    await youtube.Videos.Streams.DownloadAsync(streamInfo, allegedPath);

                    if (MapleHome.saveMusic)
                    {

                        keepfile = true;
                    }
                    else
                    { 
                        keepfile = false; 
                    
                    }
                    MapleHome.debugConsole.WriteToDebugConsole($"Audio File Download Done");

                }
                else
                {
                    keepfile = true;
                    MapleHome.debugConsole.WriteToDebugConsole($"Audio File Already Exists");
                }

            }
            if (MapleHome.playAudio)
            {
                MapleHome.debugConsole.WriteToDebugConsole($"Playing in Audio Mode");
                Song song = new Song();
                song.author = videoAuthor;
                song.title = videoTitle;
                song.length = videoDuration;
                song.url = videoDataUrl;
                song.path = allegedPath;
                song.keepFile = keepfile;


                MapleHome.debugConsole.WriteToDebugConsole($"song.title -{song.title}");
                MapleHome.debugConsole.WriteToDebugConsole($" song.author-{song.author}");
                MapleHome.debugConsole.WriteToDebugConsole($" song.length-{song.length}");
                MapleHome.debugConsole.WriteToDebugConsole($"song.url-{song.url}");
                MapleHome.debugConsole.WriteToDebugConsole($"song.path -{song.path}");
                MapleHome.debugConsole.WriteToDebugConsole($"song.keepFile-{song.keepFile}");






                int playlistid = playlistCount + 1;
                playlistCount++;
                // MapleHome.debugConsole.WriteToDebugConsole($"playlistCount-{playlistCount}");
                MapleHome.debugConsole.WriteToDebugConsole($"playlistid-{playlistid}");
                song.playlistId = playlistid;

                playlist.Add(song);
                MapleHome.playlistConsole.ClearPlaylistConsole();
                MapleHome.music.DisplayAudioPlaylist();
                MapleHome.debugConsole.WriteToDebugConsole($" {song.title} added to Audio Playlist ");
                MapleHome.debugConsole.WriteToDebugConsole($" playlist count {playlist.Count}");
                //return;

            }
            if ( MapleHome.saveVideo) /// for video playback
            {

                MapleHome.debugConsole.WriteToDebugConsole($"Video Save triggered");
                //youtube = new YoutubeClient();
                videoData = searchResults1[0];
                videoTitle = videoData.Title;
                videoAuthor = videoData.Author.ChannelTitle;
                videoDuration = videoData.Duration.ToString();
                videoDataUrl = videoData.Url;
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
                MapleHome.debugConsole.WriteToDebugConsole($"Getting Streams");
                try
                {
                    var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    // streamInfo = streamManifest.GetMuxedStreams().


                    fileName = $"{videoData.Title} by {videoData.Author.ChannelTitle} ";
                    MapleHome.debugConsole.WriteToDebugConsole($"Video {videoData.Title} set for download");

                    var videoFolder = MapleHome.videoSavePath;
                    allegedVideoPath = System.IO.Path.Combine(videoFolder, $"{fileName}.{streamInfo.Container}");
                    MapleHome.debugConsole.WriteToDebugConsole($"alleged {allegedVideoPath} set for video download");


                    // videoFilePath = NextAvailableFilename(allegedVideoPath); // enable to allow duplicate files to be saved.

                    if(!File.Exists(allegedVideoPath))
                    {
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, allegedVideoPath);
                    MapleHome.debugConsole.WriteToDebugConsole($"Video {videoData.Title} downloaded");



                    }
                    else
                    {
                        MapleHome.debugConsole.WriteToDebugConsole($"Video {videoData.Title} Already Exists");
                    }
                }
                catch (Exception ex)
                {
                    MapleHome.musicForm.WriteToMapleConsole($"Video {videoData.Title} download failed");
                    MapleHome.musicForm.WriteToMapleConsole($"Error {ex.Message}");
                }

            }
            if (MapleHome.playVideo)
            {
                Video video = new Video();
                video.author = videoAuthor;
                video.title = videoTitle;
                video.length = videoDuration;
                video.url = videoDataUrl;
                video.path = allegedVideoPath;

                int playlistid = videoPlaylistCount + 1;
                videoPlaylistCount++;
                video.playlistId = playlistid;
                // helper.WriteToMapleConsole($" Song playlist key{playlistCount + 1} value is {song.title}");
                videoPlaylist.Add(video);

                // helper.WriteToMapleConsole($" {video.title} added to Video Playlist");
                //helper.WriteToMapleConsole($" playlist count {playlist.Count}");
                //return;

            } ///for video Playback  
        }


        internal void DisplayAudioPlaylist()
        {
            
          
                List<Song> orderedPlaylist = playlist.OrderBy(i => i.playlistId).ToList();
                   
            foreach (Song song in orderedPlaylist)
            {

                MapleHome.playlistConsole.WriteToPlaylistConsole($"{song.playlistId}. {song.title}");
                //MapleHome.musicForm.WriteToMapleConsole($"Song: {song.playlistId}. {song.title}");

            }
             

        }

        internal void DisplayVideoPlaylist()
        {
            ;

            List<Video> orderedPlaylist = videoPlaylist.OrderBy(i => i.playlistId).ToList();


            foreach (Video entry in videoPlaylist)
            {
                // do something with entry.Value or entry.Key

                MapleHome.playlistConsole.WriteToPlaylistConsole($"Video: {entry.playlistId}. {entry.title}");
            }



        }

        internal void PlayNextTrack(object sender, EventArgs e)
        {
            MapleHome.debugConsole.WriteToDebugConsole($"Next Track Process started");
                
            if (playlist.Count <= 0)
            {
                MapleHome.debugConsole.WriteToDebugConsole($"No songs in playlist");
                return;
            }
            MapleHome.debugConsole.WriteToDebugConsole($"Searching for next Track");
            Song track = SearchForNextTrack();

            MapleHome.debugConsole.WriteToDebugConsole($"Next Track Found....Audio Playback Request for {track.title} Sent");
                    currentTrack=track;
                    currentTrackPlaylistId = track.playlistId;
                    //keepCurrentTrack = track.keepFile;
                     PlaySong(track.path, sender, e);



        }  
        


        internal Song SearchForNextTrack()
        {
            int nextTrackid = 1;
            Song song = new Song();
            if (currentTrackPlaylistId >= playlist.Count)
            {
                 nextTrackid = 1;
                MapleHome.debugConsole.WriteToDebugConsole($"At end of playlist starting to Start");
            }
            else
            {
                nextTrackid = currentTrackPlaylistId + 1;
                MapleHome.debugConsole.WriteToDebugConsole($"Not at end of play list");

            }

                foreach (Song track in playlist)
                {
                    if (track.playlistId == nextTrackid)
                    {
                        MapleHome.debugConsole.WriteToDebugConsole($"Next song is {track.title}");
                        currentTrack = track;
                        currentTrackPlaylistId = track.playlistId;
                        return track;

                    }
                }

            MapleHome.debugConsole.WriteToDebugConsole($"No Next Track Found");
            return song;

        }



        internal Song SearchForLastTrack()
        {
            int nextTrackid = 0;
            if (currentTrackPlaylistId <= 1)
            {
                nextTrackid =  playlist.Count;


            }
            else
            {

                nextTrackid = currentTrackPlaylistId - 1;


            }
                foreach (Song track in playlist)
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"Checking song with {track.playlistId} {track.title}");
                    if (track.playlistId == nextTrackid)
                    {
                        currentTrack = track;
                        currentTrackPlaylistId = track.playlistId;
                        return track;

                    }
                }
                MapleHome.debugConsole.WriteToDebugConsole($"No Next Track Found");
                return null;
            
        }
        internal void PlayLastTrack(object sender, EventArgs e)
        {
            try
            {

                MapleHome.debugConsole.WriteToDebugConsole($"Last Track Process started");

                if (playlist.Count <= 1)
                {
                    MapleHome.debugConsole.WriteToDebugConsole($"No songs in playlist");
                    return;
                }
                MapleHome.debugConsole.WriteToDebugConsole($"Searching for Last Track");
                Song track = SearchForLastTrack();
                //if (!File.Exists(track.path))
                //{

                //    DownloadAudioFromURL(track.url);
                //}

                MapleHome.debugConsole.WriteToDebugConsole($"Last Track Found....Audio Playback Request for {track.title} Sent");
                currentTrack = track;
                currentTrackPlaylistId = track.playlistId;
                //keepCurrentTrack = track.keepFile;
                PlaySong(track.path, sender, e);
            }
            catch (Exception ex)
            {

                MapleHome.debugConsole.WriteToDebugConsole($"Error in PlayPreviousTrack {ex.Message}");


            }



        }

        
        internal void ClearAudioPlaylist()
        {
            
            DeleteNonSavedFiles();
            playlist.Clear();
            playlistCount = 0;
            currentTrackPlaylistId = 0;
            currentTrack = null;
            MapleHome.debugConsole.WriteToDebugConsole($"Playlist Cleared");
        }
        internal void PingYouTube()
        {
          
            string apiKey = MapleHome.youtubeApiKey;
            string url = $"https://www.googleapis.com/youtube/v3/search?key={apiKey}&part=snippet&q=cat";

         
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MapleHome.debugConsole.WriteToDebugConsole("YouTube API is working!");
                    }
                    else
                    {

                        MapleHome.debugConsole.WriteToDebugConsole("API is not working!");
                    }
                }
            }
            catch (Exception ex)
            {

                MapleHome.debugConsole.WriteToDebugConsole("Error: " + ex.Message);
            }




        }

        private async Task SearchForVideo(string request)
        {

            MapleHome.debugConsole.WriteToDebugConsole($"Searching for '{request}'");
            //MapleHome.debugConsole.WriteToDebugConsole($"With API Key '{MapleHome.youtubeApiKey}'");

            if (searchResults1.Count > 0)
            {
                searchResults1.Clear();
            }
           // var videos = await MapleHome.youtube.Search.GetVideosAsync("blender tutorials");

            await foreach (var video in MapleHome.youtube.Search.GetVideosAsync(request))
            {

                if (searchResults1.Count < 1)
                {

                    searchResults1.Add(video);
                 MapleHome.debugConsole.WriteToDebugConsole($"{video.Title} added to searchresults");
                    break;

                }


                //if (searchResults1.Count < 1)
                //{

                //    switch (video)
                //    {
                //        case VideoSearchResult video:
                //            {


                //                //var id = video.Id;
                //                //var title = video.Title;
                //                //var duration = video.Duration;

                //                break;



                //            }
                //    }

                //}




            }
        }









            //try
            //{
            //    var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //    {
            //        ApiKey = MapleHome.youtubeApiKey,
            //        ApplicationName = "Maple"
            //    });
            //   // helper.WriteToMapleConsole($"Youtube services created.");
            //    //var searchListRequest = youtubeService.Search.List("snippet");

            //    var searchListRequest = youtubeService.Search.List("snippet");
            //    searchListRequest.Q = request;
            //    searchListRequest.Type = "video";
            //    searchListRequest.MaxResults = 1;


            //    var searchListResponse = await searchListRequest.ExecuteAsync();

            //    var videoId = searchListResponse.Items[0].Id.VideoId;

            //   // helper.WriteToMapleConsole($"{videoId} Video Id.");
            //    if(searchResults.Count>0)
            //    {
            //    searchResults.Clear();
            //    }
            //    searchResults.Add(videoId);

            //}
            //catch
            //{
            //    try
            //    {

            //        MapleHome.debugConsole.WriteToDebugConsole($"Main Api key failed using 2nd.");
            //        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //        {
            //            ApiKey = Properties.Settings.Default.YoutubeApiKey2,
            //            ApplicationName = "Maple"
            //        });
            //        MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //        //var searchListRequest = youtubeService.Search.List("snippet");

            //        var searchListRequest = youtubeService.Search.List("snippet");
            //        searchListRequest.Q = request;
            //        searchListRequest.Type = "video";
            //        searchListRequest.MaxResults = 1;


            //        var searchListResponse = await searchListRequest.ExecuteAsync();

            //        var videoId = searchListResponse.Items[0].Id.VideoId;

            //        MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //        if (searchResults.Count > 0)
            //        {
            //            searchResults.Clear();
            //        }
            //        searchResults.Add(videoId);
            //    }
            //    catch
            //    {

            //        try
            //        {

            //            MapleHome.debugConsole.WriteToDebugConsole($"2nd Api key failed using 3rd.");
            //            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //            {
            //                ApiKey = Properties.Settings.Default.YoutubeApiKey3,
            //                ApplicationName = "Maple"
            //            });
            //            MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //            //var searchListRequest = youtubeService.Search.List("snippet");

            //            var searchListRequest = youtubeService.Search.List("snippet");
            //            searchListRequest.Q = request;
            //            searchListRequest.Type = "video";
            //            searchListRequest.MaxResults = 1;


            //            var searchListResponse = await searchListRequest.ExecuteAsync();

            //            var videoId = searchListResponse.Items[0].Id.VideoId;

            //            MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //            if (searchResults.Count > 0)
            //            {
            //                searchResults.Clear();
            //            }
            //            searchResults.Add(videoId);
            //        }
            //        catch
            //        {
            //            try
            //            {

            //                MapleHome.debugConsole.WriteToDebugConsole($"3rd Api key failed using 4th.");
            //                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                {
            //                    ApiKey = Properties.Settings.Default.YoutubeApiKey4,
            //                    ApplicationName = "Maple"
            //                });
            //                MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                //var searchListRequest = youtubeService.Search.List("snippet");

            //                var searchListRequest = youtubeService.Search.List("snippet");
            //                searchListRequest.Q = request;
            //                searchListRequest.Type = "video";
            //                searchListRequest.MaxResults = 1;


            //                var searchListResponse = await searchListRequest.ExecuteAsync();

            //                var videoId = searchListResponse.Items[0].Id.VideoId;

            //                MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                if (searchResults.Count > 0)
            //                {
            //                    searchResults.Clear();
            //                }
            //                searchResults.Add(videoId);
            //            }
            //            catch
            //            {

            //                try
            //                {

            //                    MapleHome.debugConsole.WriteToDebugConsole($"4th Api key failed using 5th.");
            //                    var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                    {
            //                        ApiKey = Properties.Settings.Default.YoutubeApiKey5,
            //                        ApplicationName = "Maple"
            //                    });
            //                    MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                    //var searchListRequest = youtubeService.Search.List("snippet");

            //                    var searchListRequest = youtubeService.Search.List("snippet");
            //                    searchListRequest.Q = request;
            //                    searchListRequest.Type = "video";
            //                    searchListRequest.MaxResults = 1;


            //                    var searchListResponse = await searchListRequest.ExecuteAsync();

            //                    var videoId = searchListResponse.Items[0].Id.VideoId;

            //                    MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                    if (searchResults.Count > 0)
            //                    {
            //                        searchResults.Clear();
            //                    }
            //                    searchResults.Add(videoId);
            //                }
            //                catch
            //                {
            //                    try
            //                    {

            //                        MapleHome.debugConsole.WriteToDebugConsole($"5th Api key failed using6th.");
            //                        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                        {
            //                            ApiKey = Properties.Settings.Default.YoutubeApiKey6,
            //                            ApplicationName = "Maple"
            //                        });
            //                        MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                        //var searchListRequest = youtubeService.Search.List("snippet");

            //                        var searchListRequest = youtubeService.Search.List("snippet");
            //                        searchListRequest.Q = request;
            //                        searchListRequest.Type = "video";
            //                        searchListRequest.MaxResults = 1;


            //                        var searchListResponse = await searchListRequest.ExecuteAsync();

            //                        var videoId = searchListResponse.Items[0].Id.VideoId;

            //                        MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                        if (searchResults.Count > 0)
            //                        {
            //                            searchResults.Clear();
            //                        }
            //                        searchResults.Add(videoId);
            //                    }
            //                    catch
            //                    {
            //                        try
            //                        {

            //                            MapleHome.debugConsole.WriteToDebugConsole($"6th Api key failed using7th.");
            //                            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                            {
            //                                ApiKey = Properties.Settings.Default.YoutubeApiKey7,
            //                                ApplicationName = "Maple"
            //                            });
            //                            MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                            //var searchListRequest = youtubeService.Search.List("snippet");

            //                            var searchListRequest = youtubeService.Search.List("snippet");
            //                            searchListRequest.Q = request;
            //                            searchListRequest.Type = "video";
            //                            searchListRequest.MaxResults = 1;


            //                            var searchListResponse = await searchListRequest.ExecuteAsync();

            //                            var videoId = searchListResponse.Items[0].Id.VideoId;

            //                            MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                            if (searchResults.Count > 0)
            //                            {
            //                                searchResults.Clear();
            //                            }
            //                            searchResults.Add(videoId);
            //                        }
            //                        catch
            //                        {

            //                            try
            //                            {

            //                                MapleHome.debugConsole.WriteToDebugConsole($"7th Api key failed using 9th.");
            //                                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                                {
            //                                    ApiKey = Properties.Settings.Default.YoutubeApiKey8,
            //                                    ApplicationName = "Maple"
            //                                });
            //                                MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                                //var searchListRequest = youtubeService.Search.List("snippet");

            //                                var searchListRequest = youtubeService.Search.List("snippet");
            //                                searchListRequest.Q = request;
            //                                searchListRequest.Type = "video";
            //                                searchListRequest.MaxResults = 1;


            //                                var searchListResponse = await searchListRequest.ExecuteAsync();

            //                                var videoId = searchListResponse.Items[0].Id.VideoId;

            //                                MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                                if (searchResults.Count > 0)
            //                                {
            //                                    searchResults.Clear();
            //                                }
            //                                searchResults.Add(videoId);
            //                            }
            //                            catch
            //                            {

            //                                try
            //                                {

            //                                    MapleHome.debugConsole.WriteToDebugConsole($"8th Api key failed using 9th.");
            //                                    var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                                    {
            //                                        ApiKey = Properties.Settings.Default.YoutubeApiKey9,
            //                                        ApplicationName = "Maple"
            //                                    });
            //                                    MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                                    //var searchListRequest = youtubeService.Search.List("snippet");

            //                                    var searchListRequest = youtubeService.Search.List("snippet");
            //                                    searchListRequest.Q = request;
            //                                    searchListRequest.Type = "video";
            //                                    searchListRequest.MaxResults = 1;


            //                                    var searchListResponse = await searchListRequest.ExecuteAsync();

            //                                    var videoId = searchListResponse.Items[0].Id.VideoId;

            //                                    MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                                    if (searchResults.Count > 0)
            //                                    {
            //                                        searchResults.Clear();
            //                                    }
            //                                    searchResults.Add(videoId);
            //                                }
            //                                catch
            //                                {

            //                                    try
            //                                    {

            //                                        MapleHome.debugConsole.WriteToDebugConsole($"9th Api key failed using 10th.");
            //                                        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                                        {
            //                                            ApiKey = Properties.Settings.Default.YoutubeApiKey10,
            //                                            ApplicationName = "Maple"
            //                                        });
            //                                        MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                                        //var searchListRequest = youtubeService.Search.List("snippet");

            //                                        var searchListRequest = youtubeService.Search.List("snippet");
            //                                        searchListRequest.Q = request;
            //                                        searchListRequest.Type = "video";
            //                                        searchListRequest.MaxResults = 1;


            //                                        var searchListResponse = await searchListRequest.ExecuteAsync();

            //                                        var videoId = searchListResponse.Items[0].Id.VideoId;

            //                                        MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                                        if (searchResults.Count > 0)
            //                                        {
            //                                            searchResults.Clear();
            //                                        }
            //                                        searchResults.Add(videoId);
            //                                    }
            //                                    catch
            //                                    {

            //                                        try
            //                                        {

            //                                            MapleHome.debugConsole.WriteToDebugConsole($"10th Api key failed using Last.");
            //                                            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //                                            {
            //                                                ApiKey = Properties.Settings.Default.YoutubeApiKey11,
            //                                                ApplicationName = "Maple"
            //                                            });
            //                                            MapleHome.debugConsole.WriteToDebugConsole($"Youtube services created.");
            //                                            //var searchListRequest = youtubeService.Search.List("snippet");

            //                                            var searchListRequest = youtubeService.Search.List("snippet");
            //                                            searchListRequest.Q = request;
            //                                            searchListRequest.Type = "video";
            //                                            searchListRequest.MaxResults = 1;


            //                                            var searchListResponse = await searchListRequest.ExecuteAsync();

            //                                            var videoId = searchListResponse.Items[0].Id.VideoId;

            //                                            MapleHome.debugConsole.WriteToDebugConsole($"{videoId} Video Id.");
            //                                            if (searchResults.Count > 0)
            //                                            {
            //                                                searchResults.Clear();
            //                                            }
            //                                            searchResults.Add(videoId);
            //                                        }
            //                                        catch (Exception ex)
            //                                        {


            //                                            MapleHome.debugConsole.WriteToDebugConsole($"All API failed. reason:  {ex.Message}");

            //                                        }




            //                                    }





            //                                }





            //                            }





            //                        }





            //                    }




            //                }









            //            }


            //        }






            //    }
            //}

            // helper.WriteToMapleConsole($"{searchResults[0]} Results Id.");
            // helper.WriteToMapleConsole($"{searchResults.Count} Total Results Found.");

        //}

        private void ClearSearchResults()
        {

            searchResults.Clear();
        }

        public static string NextAvailableFilename(string path)
        {
           Helpers helper = new Helpers();
            if (!File.Exists(path))
            {
               // helper.WriteToMapleConsole($"File name available");

                return path;
            }
           
            // If path has extension then insert the number pattern just before the extension and return next filename
            else if (System.IO.Path.HasExtension(path))
                return GetNextFilename(path.Insert(path.LastIndexOf(System.IO.Path.GetExtension(path)), numberPattern));

            else 
            {
               // helper.WriteToMapleConsole($"Renaming file");
                return GetNextFilename(path + numberPattern);
            }

        }
       

        private static string GetNextFilename(string pattern)
        {
            string tmp = string.Format(pattern, 1);
            if (tmp == pattern)
                throw new ArgumentException("The pattern must include an index place-holder", "pattern");

            if (!File.Exists(tmp))
                return tmp; // short-circuit if no matches

            int min = 1, max = 2; // min is inclusive, max is exclusive/untested

            while (File.Exists(string.Format(pattern, max)))
            {
                min = max;
                max *= 2;
            }

            while (max != min + 1)
            {
                int pivot = (max + min) / 2;
                if (File.Exists(string.Format(pattern, pivot)))
                    min = pivot;
                else
                    max = pivot;
            }

            return string.Format(pattern, max);
        }
       public  class Video
        {
            public string? title { get; set; }
            public string? length { get; set; }
            public string? author { get; set; }
            public string? url { get; set; }
            public string? path { get; set; }
            public int playlistId { get; set; }

        }

        public  class Song
        {

            public string? title { get; set; }
            public string? length { get; set; }
            public string? author { get; set; }
            public string? url { get; set; }
            public string? path { get; set; }

            public bool keepFile { get; set; }
            public int playlistId { get; set; }

        }
    }

   
}
