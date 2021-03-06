1. Убей дракона. Ты начинающий рыцарь и можешь одолеть дракона, только если он молодой (младше `150` лет) или сильно ранен (количество здоровья меньше `50` из `100`). Напиши программу, которая по введенным параметрам дракона советует тебе нападать или отступать

2. Программа спрашивает твой возраст и говорит тебе, подросток ты или нет (больше или равно `10` и меньше `20` лет)

3. Пользователь вводит три целых числа. Найдите наибольшее из них (программа должна вывести ровно одно целое число)

4. Ты у входа в пещеру, которую охраняет огр. У тебя есть варианты действий:

   1. Вступить в бой (ты погибаешь, так как огр сильнее)
   2. Ты отступаешь (переносишься в соседнюю локацию)
   3. Подкупаешь огра (он пропускает тебя внутрь)
   4. Ищешь обходной путь (по пути тебя грабят бандиты)

5. В математике функция `sign(x)` (знак числа) определена так: 

   ```csharp
   sign(x) = 1,   если x > 0, 
   sign(x) = -1,  если x < 0, 
   sign(x) = 0,   если x = 0.
   ```

   Пользователь вводит число `x`. Для данного числа `x` выведите значение `sign(x)`.

## Текстовый квест

Ты - супергерой. Твоя задача - вызволить принцессу/принца из плена Всемирной Сети, куда она/он попала, по неосторожности ткнув в рекламный баннер. В самом начале ты только-только получил известие о неприятности, и стоишь перед выбором:

1. Поиграть в Доту (приводит к концу игры в стиле "Ты просидел в Доте до утра, и принцессу спас другой хакер")
2. Узнать, на каком сайте она застряла (следующий фрейм)

Рассказывается, что принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт `dontclickme.noob`. Варианты поведения:

1. Послушаться совета в адресе сайта и поиграть в Доту (конец игры, проигрыш - другой хакер спас принцессу)
2. Перейти на сайт (конец игры, проигрыш - игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером)
3. Обновить антивирус, а потом перейти на сайт (следующий фрейм)

Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет `2 + 2 * 2`? Варианты поведения:

1. "А, ну ее, математика для нубов! Пойду в Доту поиграю!" (конец игры, проигрыш - другой хакер спас принцессу)
2. Проверить исходный код Капча-Монстра (следующий фрейм)
3. 6 (конец игры, проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как `(2 + 2) * 2`)

Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне! Варианты поведения:

1. "Круто, пойду попробую так в своей программе!" (конец игры, проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо)
2. Ответить монстру: 6 (конец игры, проигрыш - зря, что ли, подвох находил??)
3. Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра (следующий фрейм)

Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет `(2 + 2 ) * 2`? Варианты поведения:

1. 8 (следующий фрейм)
2. Герою лень считать, и он идет в Доту (конец игры, проигрыш - другой хакер спас принцессу)

Капча-Монстр обиженно сопит "Как ты догадался? Я же спрятал скобки!", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: "Замечена и заблокирована вредоносная программа: `WinLock 1.0`. Файл-лекарство можно найти здесь: `C:\Antivirus\cure.exe`". Варианты действий:

1. Отправить лекарство принцессе по почте и пойти в Доту (конец игры, проигрыш - у нее сломался компьютер, она не может получить твой файл! принцессу спасает другой хакер)
2. Записать лекарство на флешку и пойти к принцессе/принцу домой (победа!)
