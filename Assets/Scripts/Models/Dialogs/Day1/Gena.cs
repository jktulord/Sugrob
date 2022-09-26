using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class GenaDay1 
{
    public static Dialog Get1(){
        return new Dialog(
            new Dictionary<string, Entry>(){
                {"Gena_Day1_intro", new Entry(
                    "Gena_Day1_intro", "Ярослав, приветствую тебя. Что расскажешь мне о себе, о своих впечатлениях? Есть какие-нибудь мысли о том, что здесь происходит? Я вот нахожу интересным тот факт, что данный мессенджер по-большому счёту - ничем не примечателен.$",
                    EntryType.Chain,
                    _id_transition:"Gena_Day1_hub")},
                // Тюльпан 1
                {"Gena_Day1_hub", new Entry(
                    "Gena_Day1_hub", "",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Фиолетово. Вообще, не сильно заинтересован. Буду рад узнать что-нибудь интересное, но в целом как-то всё равно.",
                        "Gena_Day1_hub1",
                        new Condition[]{
                            new Condition("Gena_Day1_hub1", ConditionType.IfFalse) 
                        },
                        new Trigger[]{
                            new Trigger("Gena_Day1_hub1", TriggerType.SetToTrue),
                        }), 

                        new Answer("Вообще, мне кажется, что люди, обитающие в неком эфире виртуальности - по определению специфичные. Ждать от них можно разного, но ты в любом случае будешь неудовлетворён. ",
                        "Gena_Day1_hub2",
                        new Condition[]{
                            new Condition("Gena_Day1_hub2", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("Gena_Day1_hub2", TriggerType.SetToTrue),
                        }), 

                        new Answer("Погоди, а как же эпохальный, уникальный и свосем-уж-точно непростецкий принцип ненужного ограничения для пользователя?",
                        "Gena_Day1_hub3",
                        new Condition[]{
                            new Condition("Gena_Day1_hub3", ConditionType.IfFalse),
                        },
                        new Trigger[]{
                            new Trigger("Gena_Day1_hub3", TriggerType.SetToTrue),
                        }),
                        // Переход в Топик 1
                        new Answer("Что тебя увлекло? Какой твой резон находится тут?",
                        "Gena_Day1_theme1_1",
                        new Condition[]{
                            new Condition("Gena_Day1_theme1_1", ConditionType.IfFalse ),
                        },
                        new Trigger[]{
                            new Trigger("Gena_Day1_theme1_1", TriggerType.SetToTrue),
                        }),

                        // Переход в Топик 2
                        new Answer("Ты ведь встретил уже местного творца? Что скажешь о нём? Какая у него выгода в его деятельности?",
                        "Gena_Day1_theme2_1",
                        new Condition[]{
                            new Condition("Gena_Day1_theme2_1", ConditionType.IfFalse ),
                        },
                        new Trigger[]{
                            new Trigger("Gena_Day1_theme2_1", TriggerType.SetToTrue),
                        }),
                    })},
                    // Тюльпан Хаба
                    {"Gena_Day1_hub1", new Entry(
                    "Gena_Day1_hub1", "Ну что же вы, голубчик! Не горячитесь раньше времени. Чуть позже может станет поинтереснее. Может и нет, но ты не сдавайся. Может даже подружишься с кем-нибудь или поймёшь что-то.",
                    EntryType.Chain,
                    _id_transition:"Gena_Day1_hub")},

                    {"Gena_Day1_hub2", new Entry(
                    "Gena_Day1_hub2", "Я, например, лишь тут и обитаю. Сфера деятельности такая - быть среди эфира. Неудовлетворённость? Попробуй над собой поработать или партнёра смени. Говорят помогает в этой проблеме.",
                    EntryType.Chain,
                    _id_transition:"Gena_Day1_hub")},

                    {"Gena_Day1_hub3", new Entry(
                    "Gena_Day1_hub3", "Да ну оно и ежу понятно, что принцип не ахти и вполне банален. Тут не поспорю. Мне любопытно то, что судя по его разработчикам - это такие же простые люди, как и мы с тобой. Слегка настораживает.",
                    EntryType.Chain,
                    _id_transition:"Gena_Day1_hub")},

                    // Тема 1
                    {"Gena_Day1_theme1_1", new Entry(
                    "Gena_Day1_theme1_1", "Совершенно обыкновенный 'резон'. Скука. Тоска. Ограничения. Частично моя работа со всем этим связана. Кто-то изучает общество в целом, а кто-то отдельные случаи, в частности. Делаю что хочу, главное закону не перечить.$"
                    +"(абзац)$"
                    +"Об этом месте вообще ведь мало что известно. Создатели обычные люди. Написали, выложили, заверили. Всё ровненько гладенько. Не проект, по отмыванию чьих-то денег, ни новая площадка для рекламы. Очень гладенько и чисто.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Быть может, смысл вещей стоит не за их создателями, а за продуктом их деятельности?",
                        "Gena_Day1_theme1_2")
                    })},
                    {"Gena_Day1_theme1_2", new Entry(
                    "Gena_Day1_theme1_2", "Главное, чтобы не продуктом жизнедеятельности. Сложный вопросик, Ярик. То, что закладывал Творец в своё произведение сокрыто в основном лишь в его голове. Мысль не новая. Новых мыслей я возможно вообще не дам. Так вот, творение сужествует таким какое оно есть - только для Творца. Нам же - плебеям - огрызки. А теперь читай по слогам, если мы ничего не знаем о творце и его глазками не смотрели, то что нам думать о его работе?",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Что та работа, которую мы видим, становится персонально нашей, так как наше восприятие всё вокруг искажает относительно нас? Прости за тавтологию.",
                        "Gena_Day1_theme1_3")
                    })},
                    {"Gena_Day1_theme1_3", new Entry(
                    "Gena_Day1_theme1_3", "Тавтология не страшна. Страшно то, что этот Творец, может нас конкретно так обмануть. Слово такое, грубое просится, не буду его говорить. Вот так, обманет он нас - а мы? И кабанчиком уже и не метнуться!$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("А про что именно мы говорит? Сделаю вид, что не совсем понимаю. И в чём обман?",
                        "Gena_Day1_theme1_4")
                    })},
                    {"Gena_Day1_theme1_4", new Entry(
                    "Gena_Day1_theme1_4", "Извлеки из этого 'эфира' некую отправную точку, и строй от неё свои мысли. Контекста для тебя полно. Кхм. Обман стоит за выгодой. Нам нужно понять, в чём выгода Творца, найти его мысль. Если он продаёт товар, то удержать с него налог не сложно. Сложно сделать налог на 'мыслю'. Жирновато ему будет, одному веселиться и радоваться своей гениальности. пусть обществу пользу оказывает, если способность к этому имеется.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Ген, ты не обижайся, но ты сказал как пёрнул. Аж глаза режет. Он ведь уже лишён способности посмотреть на результат деятельности глазами обывателя. Режиссёр не увидит свой идеальный спектакль, например. Налоги это здорово, но не от нуждающихся же.",
                        "Gena_Day1_theme1_5")
                    })},
                    {"Gena_Day1_theme1_5", new Entry(
                    "Gena_Day1_theme1_5", "Ну что ты в самом деле. Кто не нуждается в лишней радости, а? И потом, подумай сам, что стоит за человеком что-либо создающим? Нужда? Неоходимость? Вот на кой чёрт сделали Сугроб? Не совсем понятно. Ладно бы, разработчики грант какой попили, но ведь нет. не было у них причины что-то делать и нет. Я же скажу - была причина, могут быть последствия. И если они что-то с этого получили - то я хочу знать - что именно.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Слава, деньги, самомнение?",
                        "Gena_Day1_theme1_6")
                    })},
                    {"Gena_Day1_theme1_6", new Entry(
                    "Gena_Day1_theme1_6", "Это по умолчанию 'налогом' облагается. Ладненько, я пока продолжу свои поиски.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Надеюсь, найдёшь, что ищешь.",
                        "Gena_Day1_theme1_7")
                    })},
                    
                    {"Gena_Day1_theme1_7", new Entry(
                    "Gena_Day1_theme1_7", "",
                    EntryType.Chain,
                    _id_transition:"Gena_Day1_hub")},

                    // Тема 2  
                    {"Gena_Day1_theme2_1", new Entry(
                    "Gena_Day1_theme2_1", "Да, пообщались. Он интересен. Выгода - тащится от себя. Можно бы и нам от него тащиться, очароваться, но не хочется. Думаю, всё что он говорит - продуманно, отрепетированно. Может даже уже отрепетировано на ком-то. Не вижу в нём свежести.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Сюда бы рекламу зубной пасты или стирального порошка... Что бы изменилось, если бы эта свежесть была?",
                        "Gena_Day1_theme2_2")
                    })},
                    {"Gena_Day1_theme2_2", new Entry(
                    "Gena_Day1_theme2_2", "Я немногим раньше тебя зарегистрировался здесь, так что так далеко думать не могу. Мне кажется, что его чувства были бы сильнее. Можешь перечитать его текст - поймёшь, что он всё пригладил, поправил, причесал, прилизал. В живую так разговаривают?$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("У переписки есть особенности, что сильно отличает её от вербальной коммуникации.",
                        "Gena_Day1_theme2_3")
                    })},
                    {"Gena_Day1_theme2_3", new Entry(
                    "Gena_Day1_theme2_3", "Ярослав, вы такой умный! Я просто поражаюсь! Знаю я. Все мы мысли так или иначе прихорашиваем, но он это выпячивает. У меня есть подозрение, что он так чувства свои маскирует. Не знаю что. Быть может, если бы он так не обыгрывал всё это, то нам пришлось бы выслушивать самые разные тантрумы и потоки ненависти. Представь себе монолог непрекращающейся злости! Или напротив, бесконечную оду любви.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Ты просто это всё нафантазировал или реально так думаешь? Выглядишь либо как фантазёр, либо как довольно проницательный человек.",
                        "Gena_Day1_theme2_4")
                    })},    
                    {"Gena_Day1_theme2_4", new Entry(
                    "Gena_Day1_theme2_4", "Просто внимательный. Посмотри за людьми. Сначало сумбурно. Потом, некоторые вещи замечаешь, выводы всякие делаешь, да. Я не говорю, что понимаю его полностью, это всего лишь моё первое впечатление. Так сказать, заметки на полях.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Можно я за тобой понаблюдаю? Мне даже интересно что ты о других скажешь, ну и о себе.",
                        "Gena_Day1_theme2_5")
                    })},    
                    {"Gena_Day1_theme2_5", new Entry(
                    "Gena_Day1_theme2_5", "Ну хоть кто-то за мной присмотрит. Давай, давай. Даже не знаю, начало вроде уже заложили, можем позже продолжить. На ходу сочинять легенду не хочу, лучше подготовиться и рассказать тебе правду.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Ладненько. Позже так позже.",
                        "Gena_Day1_theme2_6")
                    })}, 
                    {"Gena_Day1_theme2_6", new Entry(
                    "Gena_Day1_theme2_6", "",
                    EntryType.End)},      
    });
    }
}