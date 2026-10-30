using Task_1.Interfaces;

namespace Task_1.Models
{
    public class MonthService : IDataListService
    {
        public IEnumerable<string> GetItems()
        {
            return
            [
                "Січень", "Лютий", "Березень", "Квітень",
                "Травень", "Червень", "Липень", "Серпень",
                "Вересень", "Жовтень", "Листопад", "Грудень"
            ];
        }
    }
}
