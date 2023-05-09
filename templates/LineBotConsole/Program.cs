// See https://aka.ms/new-console-template for more information
var ChannelAccessToken = "$ChannelAccessToken$";
var UserId = "$UserId$";
var bot = new isRock.LineBot.Bot(ChannelAccessToken);
//push text
bot.PushMessage(UserId, "Hello World");
//push sticker
bot.PushMessage(UserId, 1, 3);
//push image
bot.PushMessage(UserId, new Uri("https://i.imgur.com/OQx8aid.png"));
//push Audio
var AudioMsg = new isRock.LineBot.AudioMessage(
new Uri("https://arock.blob.core.windows.net/blogdata202008/test.mp3"), 6000);
bot.PushMessage(UserId, AudioMsg);
//push Video            
var VideoMsg = new isRock.LineBot.VideoMessage(
new Uri("https://arock.blob.core.windows.net/blogdata202008/POC.mp4"),
new Uri("https://imgur.com/LPQhfXR.png")
);
bot.PushMessage(UserId, VideoMsg);
//push location
var LocationMsg = new isRock.LineBot.LocationMessage(
"大安森林公園", "台北市大安區新生南路二段1號", 25.030000, 121.535833);
bot.PushMessage(UserId, LocationMsg);