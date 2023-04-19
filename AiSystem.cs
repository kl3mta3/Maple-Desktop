using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;

using System.Runtime.InteropServices;
using MapleHome;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json.Linq;


namespace MapleHome
{
    public class AiSystem
    {
        internal static string question { get; set; }
        internal static  int answerSegmentLength = 18;
        internal static int answerTotalLength = 0;
        internal static int answerCurrentLength = 0;
        internal static bool firstAnswer = true;
        internal static bool partialAnswerSent = false;
        public void AskQuestion(string value)
        {
            //MapleHome.aiForm.WriteToMapleConsole($"Question Posted");
            MapleHome.debugConsole.WriteToDebugConsole($"Ai System Recieved Question {value}.");
            // Helpers helper = new Helpers();
            // helper.WriteToMapleConsole($"Ai System Recieved Question {value}.");

            question = value;
            //AskChatGPTStream();
            //AskGptStream();
            AskChatGPT();
        }
        public static async Task AskChatGPT()
        {

            MapleHome.aiForm.WriteToMapleConsole($"Me: {question}");
            MapleHome.debugConsole.WriteToDebugConsole($"Ai System Started Request.");
            string? answer = "";
            Helpers helper = new Helpers();
            var gpt3 = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = MapleHome.openAiToken,
            });



            var completionResult = await gpt3.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {

                Messages = new List<ChatMessage>
                {

                    ChatMessage.FromUser(question)
                },
                Model = Models.ChatGpt3_5Turbo,

                Temperature = 0.5F,
                //Stream = true,
                MaxTokens = 1000
            });

            foreach (var completion in completionResult.Choices)
            {
                if (completionResult.Successful)
                {

                    answer = completionResult.Choices.First().Message.Content;
                    string response = $"Maple: {answer}";

                    //MapleHome.aiForm.WriteToMapleConsole("");
                    MapleHome.aiForm.AnswerToMapleConsole($"{response}", Color.PaleTurquoise);
                    MapleHome.debugConsole.WriteToDebugConsole($"Ai System Sent Answer.");

                    // helper.AnswerToMapleConsole(response, Color.PaleTurquoise);

                }
                else
                {
                    if (completionResult.Error == null)
                    {
                        MapleHome.aiForm.WriteToMapleConsole($"Unknown Error: Check Api Token.");
                        throw new Exception("Unknown Error");
                    }


                   // helper.WriteToMapleConsole($"{completionResult.Error.Code}: {completionResult.Error.Message}");


                }
            }


        }


        public void AskGptStream()
        {

            //AskChatGPTStream();
            AskChatGPT();


        }

        public static async Task AskChatGPTStream()
        {
            MapleHome.aiForm.WriteToMapleConsole($"Me: {question}");
            string? answer = "";
            string answerHolder = "";
            var gpt3 = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = MapleHome.openAiToken,
            });

            var completionResult = gpt3.ChatCompletion.CreateCompletionAsStream(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
             {
                     new(StaticValues.ChatMessageRoles.System, question),
                       
            },
                Stream = false,
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 1000
            });
            MapleHome.aiForm.InsertMapleTag();
          
            await foreach (var completion in completionResult)
            {
                if (completion.Successful)
                {
                    //if (firstAnswer)
                    //{
                    //    answerTotalLength = completion.Choices.Count;
                    //    MapleHome.aiForm.PostQuestionToConsole($" Completion total count {completion.Choices.Count}", Color.PaleTurquoise);
                    //    firstAnswer =false;
                    //}
                    
                    answer = completion.Choices.First().Message.Content;
                    //answerCurrentLength++;
                   answerHolder += (answer);
                    if (answerHolder.Length >= answerSegmentLength)
                        {
                        partialAnswerSent = true;
                        string response = answerHolder;
                         MapleHome.aiForm.AnswerToMapleConsoleStream($"{answerHolder}", Color.PaleTurquoise);
                        answerHolder = "";
                         }
                    //if (!partialAnswerSent && answerTotalLength == answerCurrentLength)
                    //{

                    //    partialAnswerSent = true;
                    //    string response = answerHolder;
                    //    MapleHome.aiForm.AnswerToMapleConsoleStream($"{answerHolder}", Color.PaleTurquoise);
                    //    answerHolder = "";

                    //}


                }
                else
                {
                    if (completion.Error == null)
                    {
                        throw new Exception("Unknown Error");
                    }

                   // Console.WriteLine($"{completion.Error.Code}: {completion.Error.Message}");
                }
            }

            MapleHome.aiForm.AnswerToMapleConsoleStream($"{answerHolder}", Color.PaleTurquoise);
            answerHolder = "";
            //MapleHome.aiForm.ScrollTOBottomOfBoX();



        }

    }

}



