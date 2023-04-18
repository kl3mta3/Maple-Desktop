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


        public void AskQuestion(string value)
        {

            Helpers helper = new Helpers();
            helper.WriteToMapleConsole($"Ai System Recieved Question {value}.");
            
            question = value;
            AskChatGPT();
        }
        public static async Task AskChatGPT()
        {

           
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
                    //helper.WriteToMapleConsole("");
                    MapleHome.aiForm.WriteToMapleConsole("");
                    MapleHome.aiForm.AnswerToMapleConsole($"{response}", Color.PaleTurquoise);


                    helper.AnswerToMapleConsole(response, Color.PaleTurquoise);

                }
                else
                {
                    if (completionResult.Error == null)
                    {
                        helper.WriteToMapleConsole($"Unknown Error: Check Api Token.");
                        throw new Exception("Unknown Error");
                    }


                    helper.WriteToMapleConsole($"{completionResult.Error.Code}: {completionResult.Error.Message}");


                }
            }


        }

    }



}



