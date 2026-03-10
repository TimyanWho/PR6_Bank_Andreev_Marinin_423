# Практическая работа №6 — Создание автоматизированных unit-тестов
## Выполнили El Андреев Тимофей и El Маринин Степан

Проекты:
- `Bank_Andreev_Marinin_423` — проект с реализацией класса BankAccount (.NET Framework).
- `BankTests_Andreev_Marinin_423` — проект модульных тестов (MSTest, .NET Framework).

## Содержание
Выполнено:
- Реализован класс `BankAccount` с методами `Debit` и `Credit`.
- Добавлена XML-документация к методам и свойствам.
- Исправлена ошибка в `Debit` (было `m_balance += amount`, стало `m_balance -= amount`).
- Написаны автоматизированные тесты для сценариев снятия и пополнения средств.

## Файлы
- `BankAccount.cs` — код класса.
- `BankAccountTests.cs` — набор тестов MSTest.
- `README.md` — этот файл.

## Как запустить
1. Откройте решение в Microsoft Visual Studio (рекомендуемая версия 2022).
2. Убедитесь, что оба проекта находятся в одном решении.
3. В проекте `BankTests_Andreev_Marinin_423` добавлена ссылка на проект `Bank_Andreev_Marinin_423`.
4. В Visual Studio: **Test** → **Run All Tests** (или окно Test Explorer → Run All).

## Ожидаемый результат и скриншоты
<img width="1273" height="611" alt="{858CC8E8-90C7-4596-99EE-EA96F9E7AB7A}" src="https://github.com/user-attachments/assets/e5ca97f0-d7b5-4e32-96cc-54251f46db2d" />
