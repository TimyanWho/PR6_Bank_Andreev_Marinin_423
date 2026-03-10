using System;

namespace BankAccountNS
{
    /// <summary>
    /// Класс, моделирующий банковский счёт: хранит имя клиента и баланс,
    /// предоставляет операции Debit (снять) и Credit (положить).
    /// </summary>
    public class BankAccount
    {
        /// <summary>Сообщение при попытке списать сумму, превышающую баланс.</summary>
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";

        /// <summary>Сообщение при попытке списать отрицательную сумму.</summary>
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        /// <summary>
        /// Конструктор счёта.
        /// </summary>
        /// <param name="customerName">Имя владельца счёта.</param>
        /// <param name="balance">Начальный баланс.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>Имя клиента (read-only).</summary>
        public string CustomerName
        {
            get { return m_customerName; }
        }

        /// <summary>Текущий баланс (read-only).</summary>
        public double Balance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Выполнить списание (Debit). Если amount &gt; balance или amount &lt; 0 — бросает ArgumentOutOfRangeException
        /// с детализированным сообщением.
        /// </summary>
        /// <param name="amount">Сумма списания.</param>
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
        }

        /// <summary>
        /// Пополнение счёта (Credit). Если amount &lt; 0 — бросает ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="amount">Сумма для пополнения.</param>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, "Credit amount is less than zero");
            }

            m_balance += amount;
        }

        /// <summary>
        /// Демонстрационный Main (консольный вывод) — можно оставить или удалить по желанию.
        /// </summary>
        public static void Main()
        {
            BankAccount ba = new BankAccount("Andreev & Marinin", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            // Console.ReadLine(); 
        }
    }
}