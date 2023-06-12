
using Objective.Publisher;
using Objective.Publisher.Infrastructure.Common;
using Objective.Publisher.Infrastructure.VkApi;
using Objective.Publisher.Infrastructure.VkApi.Method;

VkApi vkApi = new();

var products = vkApi.Method<Market>();
var wall = vkApi.Method<Wall>();
var photo = vkApi.Method<Photo>();

//Получаем все айтемы
var itemProd = products.GetAllAsync().Result;

//Создаем список с рандомными продуктами
var shufleProducts = new List<Item>();

//Рандомим
while (shufleProducts.Count != itemProd.Count - 1)
{
    var random = new Random(DateTime.Now.Millisecond).Next(1, itemProd.Count);
    var randomProduct = itemProd[random];

    if (shufleProducts.Contains(randomProduct))
        continue;

    shufleProducts.Add(randomProduct);
}

int[] time = new int[] { 10, 15, 20 };

var currentDateTimePublish = new DateTime(2022, 06, 19, 1, 0, 0);
int count = 1;
var itemCounter = 0;

var taskList = new List<Task>();

var stopWatch = System.Diagnostics.Stopwatch.StartNew();
//Алгоритм постинка
foreach (var product in shufleProducts)
{
    if (itemCounter == 5)
        break;

    if (count > 3)
    {
        count = 1;
        currentDateTimePublish = currentDateTimePublish.AddHours(14);
    }
    else
        currentDateTimePublish = currentDateTimePublish.AddHours(5);

    taskList.Add(await Task.Factory.StartNew(async () =>
    {
        var serverInfo = await photo.UploadPhotoToServer(product.ThumbPhoto);
        var photoInfo = await photo.SaveWallPhoto(serverInfo);
        var item = product.ToMarketProduct();

        wall.Post(item, photoInfo.Response[0], VkApi.DateTimeToUnixTime(currentDateTimePublish));
    }));
    Console.WriteLine($"Была заплонирована публикация товара {product.Title} на время {currentDateTimePublish.ToShortDateString()} {currentDateTimePublish.ToShortTimeString()}");
    Thread.Sleep(500);
    itemCounter++;
    count++;
}

Task.WaitAny(taskList.ToArray());
stopWatch.Stop();
Console.WriteLine(stopWatch.ElapsedMilliseconds);




