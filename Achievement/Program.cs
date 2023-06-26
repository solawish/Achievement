// See https://aka.ms/new-console-template for more information
using Achievement.Model;
using Achievement.Service;

var situationCollection = GetSituation();
var achievementService = new AchievementService(situationCollection);

var realtor1 = new Realtor() { Name = "一般般人" , Performance = 1000};
var level1 = achievementService.GetLevel(realtor1);
Console.WriteLine($"{realtor1.Name}:{level1.ToString()}");

var realtor2 = new Realtor() { Name = "好像很厲害", Performance = 9999999 };
var level2 = achievementService.GetLevel(realtor2);
Console.WriteLine($"{realtor2.Name}:{level2.ToString()}");

List<Situation> GetSituation()
{
    var situationCollection = new List<Situation>();
    var situation1 = new Situation() 
    { 
        Name = "一般般的情況",
        Level = Achievement.Enum.LevelEnum.一般般,
        IsConformTo = x => 
        {
            if (x.Performance < 10000)
            {
                return true;
            }
            return false;
        } 
    };
    situationCollection.Add(situation1);

    var situation2 = new Situation()
    {
        Name = "很厲害的情況",
        Level = Achievement.Enum.LevelEnum.年度風雲,
        IsConformTo = x => x.Performance > 100000        
    };
    situationCollection.Add(situation2);

    return situationCollection;
}