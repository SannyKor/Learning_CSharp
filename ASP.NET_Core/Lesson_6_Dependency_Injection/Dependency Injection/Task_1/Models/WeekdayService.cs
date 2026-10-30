using Task_1.Interfaces;

namespace Task_1.Models
{
    public class WeekdayService : IDataListService
    {
        public IEnumerable<string> GetItems()
        {
            return
            [
                "Понеділок",
                "Вівторок",
                "Середа",
                "Четвер",
                "П'ятниця",
                "Субота",
                "Неділя"
            ];
        }
    }
}
