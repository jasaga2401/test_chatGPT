using OpenAI_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_chatGPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {

            var openai = new OpenAIAPI(new APIAuthentication("<API Key>"));
            var conversation = openai.Chat.CreateConversation();
            conversation.AppendUserInput("How to write to console: ");
            var response = await conversation.GetResponseFromChatbotAsync();
            label1.Text = response.ToString();

        }
    }
}
