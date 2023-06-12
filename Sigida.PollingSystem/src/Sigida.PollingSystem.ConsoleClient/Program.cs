using Sigida.PollingSystem.Application;
using Sigida.PollingSystem.Entities;

var builder = new PollBuilder("Как вам это видео")
                .AddAnswer(Guid.Parse("fba15dc0-f6c4-45dc-921b-51a2376f1f45"), "Нормально")
                .AddAnswer(Guid.Parse("b54cd046-c73c-4bf0-b237-fd69b3da2cbd"), "Неплохо")
                .AddAnswer(Guid.Parse("cd43b2d0-cd93-4fba-a336-65d96d2dbb59"), "Отстой")
                .AddAnswer(Guid.Parse("a1fa3981-d4c2-421d-b5e1-7405a628d0c3"), "Супер");

var poll = builder.Build();

poll.VoteTo(Guid.Parse("b54cd046-c73c-4bf0-b237-fd69b3da2cbd"));
poll.VoteTo(Guid.Parse("b54cd046-c73c-4bf0-b237-fd69b3da2cbd"), 10);
poll.VoteTo(Guid.Parse("a1fa3981-d4c2-421d-b5e1-7405a628d0c3"));
poll.VoteTo(Guid.Parse("a1fa3981-d4c2-421d-b5e1-7405a628d0c3"));
poll.VoteTo(Guid.Parse("fba15dc0-f6c4-45dc-921b-51a2376f1f45"));
poll.VoteTo(Guid.Parse("fba15dc0-f6c4-45dc-921b-51a2376f1f45"));

//using(var context = new ApplicationDBContext())
//{
//    context.Polls.Add(poll);
//    context.SaveChanges();
//}

var result = builder.GetResult(poll);


Console.WriteLine(result.GetView());

