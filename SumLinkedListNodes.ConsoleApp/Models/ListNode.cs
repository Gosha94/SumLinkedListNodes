namespace SumLinkedListNodes.ConsoleApp.Models
{
    /// <summary>
    /// Класс описывает элемент (Ноду) связного списка
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// Значение в текущей ноде
        /// </summary>
        public int Value { get; set; }
        
        /// <summary>
        /// Ссылка на следующую ноду
        /// </summary>
        public ListNode Next { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public ListNode(int value = 0, ListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }

    }
}