using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.Data.Models;
using OnlineShop.Data.Services;
using System.Collections.Generic;
using System.Net.Http;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace OnlineShop.Bot.Controllers
{
    public class HomeController : Controller
    {

        //public HomeController(IProductService service)
        //{
        //    _service = service;
        //}
        private TelegramBotClient client = new TelegramBotClient("2116797944:AAGP2DCaZa4rXqCJoo7OwiuUr5OlBCYs10E");
        private readonly IProductService _service;
        HttpClient _httpClient = new HttpClient();
        string url = "https://localhost:44335/api/Product/getall";
        public IActionResult Index()
        {
            client.OnMessage += XabarKelganda;
            client.StartReceiving();


            return View();
        }

        private async void XabarKelganda(object sender, MessageEventArgs e)
        {
            // foydalanuvchi idsi
            long userId = e.Message.Chat.Id;

            // kelgan xabar idsi
            int msgId = e.Message.MessageId;

            //kelgan xabar
            string xabar = e.Message.Text;

            if (xabar == "/start")
            {
                await client.SendPhotoAsync(
                    chatId: userId,
                    photo: "https://i.pinimg.com/originals/0c/3d/33/0c3d33335e28855c2e7230fedeff8761.jpg",
                    caption: "Assalomu alaykum!\nOnline Phone Shop ga xush kelibsiz!\n\n@dotnet2021_bot"
                );

                ReplyKeyboardMarkup markup = new ReplyKeyboardMarkup();
                // Keyboard sinfiga oid jagged(massiv ichida massiv)
                // masivini hosil qilish 
                List<List<KeyboardButton>> buttonList = new List<List<KeyboardButton>>();
                var json = await _httpClient.GetStringAsync(url);

                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(json);

                for (int i = 0; i < list.Count; i++)
                {
                    List<KeyboardButton> keyboardButtons = new List<KeyboardButton>()
                    {
                        new KeyboardButton($"📱 {list[i].Name} ${list[0].Price}")
                    };
                    buttonList.Add(keyboardButtons);
                }
                markup.Keyboard = buttonList;

                await client.SendTextMessageAsync(
                    chatId: e.Message.Chat.Id,
                    text: "Mavjud mahsulotlar 👇",
                    replyMarkup: markup
                );

                //markup.Keyboard = new KeyboardButton[][]
                //{
                //      // 1 - qator
                //      new KeyboardButton[]
                //      {
                //         new KeyboardButton("A"),
                //         new KeyboardButton("B")
                //      },
                //      // 2 - qator
                //      new KeyboardButton[]
                //      {
                //         new KeyboardButton("C"),
                //         new KeyboardButton("D")
                //      }
                //};
            }
            else if (xabar.Contains("salom"))
            {
                // xabar yuborish
                await client.SendTextMessageAsync(
                    userId,
                    "Yaxshimisiz?",
                    replyToMessageId: msgId
                    );
            }
            else
            {
                // xabar yuborish
                await client.SendTextMessageAsync(
                    userId,
                    "Tushunarsiz buyruq",
                    replyToMessageId: msgId
                    );
            }
        }
    }
}
