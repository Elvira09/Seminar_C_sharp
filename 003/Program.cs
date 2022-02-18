// По заданному номеру дня недели вывести его название
System.Console.Write("Введите числовое значение от 1 до 7 дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
        switch (day) { 
            case 1: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Понедельник", day); 
                break; 
            case 2: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Вторник", day); 
                break;
            case 3: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Среда", day); 
                break;
            case 4: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Четверг", day); 
                break;
            case 5: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Пятница", day); 
                break;
            case 6: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Суббота", day); 
                break;
            case 7: 
                Console.WriteLine("Вы ввели число {0} и оно соответствует дню недели Воскресенье", day); 
                break;
            default: 
                Console.WriteLine("Вы ввели число не соответствующее диапозону от 1 до 7"); 
                break; 
        }