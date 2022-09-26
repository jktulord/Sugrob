using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class BorisDay1 
{
    public static Dialog Get1(){
        return new Dialog(
            new Dictionary<string, Entry>(){
                {"Boris_Day1_intro", new Entry(
                    "Boris_Day1_intro", "Привет. Не желаешь поговорить? Хотя, зачем ещё устанавливать подобное приложение, как не для разговора?$",
                    EntryType.Chain,
                    _id_transition:"Boris_Day1_hub")},
                // Тюльпан 1
                {"Boris_Day1_hub", new Entry(
                    "Boris_Day1_hub", "",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Да, вполне. Много что известно о сугробе 0.5?",
                        "Boris_Day1_hub1",
                        new Condition[]{
                            new Condition("Boris_Day1_hub1", ConditionType.IfFalse) 
                        },
                        new Trigger[]{
                            new Trigger("Boris_Day1_hub1", TriggerType.SetToTrue),
                        }), 

                        new Answer("О нет, ты меня рассекретил! Я не ожидал, что кто-то предположит, что я здесь ради общения. ",
                        "Boris_Day1_hub2",
                        new Condition[]{
                            new Condition("Boris_Day1_hub2", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("Boris_Day1_hub2", TriggerType.SetToTrue),
                        }), 

                        new Answer("Мы можем не разговаривать, а попытаться провести сеанс телепатической связи.",
                        "Boris_Day1_hub3",
                        new Condition[]{
                            new Condition("Boris_Day1_hub3", ConditionType.IfFalse),
                        },
                        new Trigger[]{
                            new Trigger("Boris_Day1_hub3", TriggerType.SetToTrue),
                        }),
                        // Переход в Топик 1
                        new Answer("Я бы хотел немного узнать о тебе, Борис. Сам я фигура весьма неприметная. Мне о себе нечего рассказать. Так что - спасай беседу, выручи меня.",
                        "Boris_Day1_theme1_1",
                        new Condition[]{
                            new Condition("Boris_Day1_theme1_1", ConditionType.IfFalse ),
                        },
                        new Trigger[]{
                            new Trigger("Boris_Day1_theme1_1", TriggerType.SetToTrue),
                        }),

                        // Переход в Топик 2
                        new Answer("Борис, а как ты относишься к людям, которые любят или нелюбят историю?",
                        "Boris_Day1_theme2_1",
                        new Condition[]{
                            new Condition("Boris_Day1_theme2_1", ConditionType.IfFalse ),
                        },
                        new Trigger[]{
                            new Trigger("Boris_Day1_theme2_1", TriggerType.SetToTrue),
                        }),
                    })},
                    // Тюльпан Хаба
                    {"Boris_Day1_hub1", new Entry(
                    "Boris_Day1_hub1", "На самом деле нет. Как могу предположить - это бета-версия оригинальной программы, что выйдет много позже. Не думаю, что 'Сугроб 0.5' - это 'Сугроб - пол-литра'. Хотя, палитра обитателей получается яркой, хоть и мрачноватой.",
                    EntryType.Chain,
                    _id_transition:"Boris_Day1_hub")},

                    {"Boris_Day1_hub2", new Entry(
                    "Boris_Day1_hub2", "Про тебя уже всё знают. Кто не знает - только притворяется, или убеждает себя, что не знает. Как и всех нас...",
                    EntryType.Chain,
                    _id_transition:"Boris_Day1_hub")},

                    {"Boris_Day1_hub3", new Entry(
                    "Boris_Day1_hub3", "Телепатия - это общение при помощи мыслей, да? Будет очень глупо, если мы будем общаться без мыслей вообще.",
                    EntryType.Chain,
                    _id_transition:"Boris_Day1_hub")},

                    // Тема 1
                    {"Boris_Day1_theme1_1", new Entry(
                    "Boris_Day1_theme1_1", "Поддержу беседу. Погода сегодня хорошая, да? Не то. Хмм. Может поговорим, о важности коллективных решениий касательно истории? Тоже не подойдёт. Ну придётся о себе рассказывать.$"
                        +"(Абзац)$"
                        +"В рабочее время я пролетарий. И труд физический, и зарплата соотвественная - да и чего скрывать, особого почёта моя профессия не имеет. Хотя нужная очень. После работы я сбегаю от капитализма в феодализм. Я активный участник реконструкторского клуба.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("И как успехи? Далеко убежал?",
                        "Boris_Day1_theme1_2")
                    })},
                    {"Boris_Day1_theme1_2", new Entry(
                    "Boris_Day1_theme1_2", "Да, вполне. Живу в другом времени. Мне там спокойнее, что-ли. Проблемы контролируемы, а ощущения новые.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("В чём веселье? В бедах и проблемах предков?",
                        "Boris_Day1_theme1_3")
                    })},
                    {"Boris_Day1_theme1_3", new Entry(
                    "Boris_Day1_theme1_3", "Побег от реальности у всех индивидуален. Развлечения - тоже. Я отдыхаю погружаясь в устаревший мир. Кто-то любит пердеть в диван, а мне нравится стрельба из лука.$"+
                    "Шоссы, кольчуга, костёр и природа. Круто же.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Тебе не нравится твоё нынешнее положение?",
                        "Boris_Day1_theme1_4")
                    })},
                    {"Boris_Day1_theme1_4", new Entry(
                    "Boris_Day1_theme1_4", "Вопрос конечно... Да, не нравится. Я много чего неприемлю. Не ретроград, просто понимаю, где нахожусь и мне хочется просто сдохнуть. Поздно каяться, всё уже сделано. Потому и отвлекаюсь. Не хочу ныть.",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Что-то случилось?",
                        "Boris_Day1_theme1_5")
                    })},
                    
                    {"Boris_Day1_theme1_5", new Entry(
                    "Boris_Day1_theme1_5", "Нет, ничего. Потому что ничего не случилось и не хочу. Сменим тему.",
                    EntryType.Chain,
                    _id_transition:"Boris_Day1_hub")},

                    // Тема 2  
                    {"Boris_Day1_theme2_1", new Entry(
                    "Boris_Day1_theme2_1", "Честно?",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Да, пожалуйста.",
                        "Boris_Day1_theme2_2")
                    })},
                    {"Boris_Day1_theme2_2", new Entry(
                    "Boris_Day1_theme2_2", "Вчера, я бы сказал, что мне 'фиолетово', но сегодня я скажу, что мне 'индифференто.'$"+
                    "Каждый развлекается по своему усмотрению. То, что я реконсруктор - не делает меня фанатом истории. У меня свои корыстные мотивы, да я их уже тебе и описал.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Неужто нет желания вскочить на броневик и заявить о важности истории? Не как реконструктор, а как персона.",
                        "Boris_Day1_theme2_3")
                    })},
                    {"Boris_Day1_theme2_3", new Entry(
                    "Boris_Day1_theme2_3", "Ну вскочу, ну заявлю. Что дальше? Я не вижу никакого смысла в подобных заявлениях, пока люди не начнут сносить памятники или крушить архитектуру. Ты думаешь, что от подобного рода заявлений в мире что-то изменится? 'Смотрите, имярек ненавидит историю!' Может любит, суть не меняется. Об этом говорят те, кто помимо реальных тягот имеют свободное время на страдания.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Ой, а не слишком ли громкие слова? Право на страдание - есть неотъемлемое право полученное при рождении. За редким исключением, но! Согласен в целом. То, что историки воспевают предмет своей работы - вполне логично.",
                        "Boris_Day1_theme2_4")
                    })},    
                    {"Boris_Day1_theme2_4", new Entry(
                    "Boris_Day1_theme2_4", "Вообще, нет. историкам, как и рабочему, спустя какое-то время становится абсолютно плевать на предмет их деятельности. Не только историкам. Всем. Если точнее, люди сталкиваются с таким количеством фактов о том, чем они занимаются, что радикально 'плохо' или радикально 'хорошо' - как минимум странно. Они будут любить глубже, чем школьник, который лишь планирует связаться с этим, как раз потому что глубже понимают. Ну или ненавидеть. Если человек подаёт себя радикально, то он или маньяк, или что-то скрывает.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Не загнул ли ты? На всякий случай присмотрюсь к этим людям. Как в целом поживаешь? Какие планы на будущее?",
                        "Boris_Day1_theme2_5")
                    })},    
                    {"Boris_Day1_theme2_5", new Entry(
                    "Boris_Day1_theme2_5", "Нормально. Недавно выдалась возможность съездить всем реконструкторским клубом в соседний город. Поучавствовал в фотосессии. Мне нанесли грим! Шрам и татуировку. Здорово, рад что выпало на выходной.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("О, а какая эпоха?",
                        "Boris_Day1_theme2_6")
                    })}, 
                    {"Boris_Day1_theme2_6", new Entry(
                    "Boris_Day1_theme2_6", "Эпоха двоцовых переворотов. Я изображал отрубленную голову у гильотины.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Головокружительно.",
                        "Boris_Day1_theme2_7")
                    })},   
                    {"Boris_Day1_theme2_7", new Entry(
                    "Boris_Day1_theme2_7", "Ты меня извини, что я немногословный. В детстве я был одиночкой, поэтому иногда могу быть неловким или неуместно скрытным. Сейчас, я иногда не понимаю, что нужно написать, чтобы диалог продолжился. Мне проще объяснить свою немногословность. Как бы, вот вроде и хочу что-то сказать, а не знаю что. Вот нет во мне возможности заговорить с человеком. Как раз в соседнем городе с незнакомкой захотел поговорить, а в голове вакуум. Так и с другими людьми бывает.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Пока что, ты общаешься довольно неплохо, и в сравнении со мной - развёрнуто. Я вот вообще пришу одним двумя предложениями. Может ты слушатель? Как вариант, я могу либо сам что-то рассказывать, либо будем делать монолог из пары сообщений. Я и сам порой реагирую и задаю вопросы так, будто бы хочу что-то выведать.",
                        "Boris_Day1_theme2_8")
                    })},   
                    {"Boris_Day1_theme2_8", new Entry(
                    "Boris_Day1_theme2_8", "Тренируйся, пробуй. Может и подтянешь навыки взаимодействия. Даже у меня вроде получается.$",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Было бы здорово.",
                        "Boris_Day1_theme2_9")
                    })},
                    {"Boris_Day1_theme2_9", new Entry(
                    "Boris_Day1_theme2_9", "",
                    EntryType.End)},      
    });
    }
}