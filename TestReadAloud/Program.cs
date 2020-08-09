using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TestReadAloud
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r1 = new System.Random();

            //var XDoc = new XDocument(new XDeclaration("1.0", "utf-8", "true"),
            //    new XElement("TotoroKaruta",                
            //     new XElement("Fuda")
            //    )
            //    );

            //XDoc.Save(@"C:\Work\TotoroKaruta.xml");

            //var xDoc = XDocument.Load(@"C:\Work\TotoroKaruta.xml");

            //var elem = new XElement("TotoroKaruta",
            //               new XElement("Fuda", "あなたはだあれ？マックロクロスケ？"),
            //               new XElement("Fuda", "いま　そこの松の木でサツキとメイが笑ったように見えた（お母さん）"),
            //               new XElement("Fuda", "おたまじゃくし！！"),
            //               new XElement("Fuda", "お父さん、お母さんね")
            //               );
            //xDoc.Elements().First().Add(elem);

            List<string> yomiageHiretu = new List<string>();
            yomiageHiretu.Add("ずーっといい子にしてたんだよねえてんてんてんてん");
            yomiageHiretu.Add("すっごくおおきいのコーンな目してるのこわーい");
            yomiageHiretu.Add("にゃーおー");
            yomiageHiretu.Add("ねこねこのばす");
            yomiageHiretu.Add("むかーしむかーしは木と人は仲良しだったんよ");
            yomiageHiretu.Add("めえのばかもうしらない");
            yomiageHiretu.Add("あなたはだあれ？マックロクロスケ");
            yomiageHiretu.Add("いまそこのまつのきでさつきとめいがわらったようにみえた");
            yomiageHiretu.Add("かしてあげる。はやく。めいが、おちちゃう");
            yomiageHiretu.Add("かわいいこじゃねえかんた");
            yomiageHiretu.Add("せんたくおわりびっくりまーく");
            yomiageHiretu.Add("そこぬけだ");
            yomiageHiretu.Add("はやくたいいんしておばけに会いたいわ");
            yomiageHiretu.Add("病院行ってくれるのありがとう");
            yomiageHiretu.Add("もう友だちができたのかい");
            yomiageHiretu.Add("やあーいおまえんち。お化け屋敷");
            yomiageHiretu.Add("ヴォロろろろろ");
            yomiageHiretu.Add("きがよけてる");
            yomiageHiretu.Add("家まで競争。あ。ずるいまって");
            yomiageHiretu.Add("くさかべさーんでんぽうでーす");
            yomiageHiretu.Add("だめだよお母さんのとうもろこしだよ");
            yomiageHiretu.Add("ちがわい");
            yomiageHiretu.Add("ゔぅあ");
            yomiageHiretu.Add("へーすごい秘密基地みたいだな");
            yomiageHiretu.Add("夢だけど夢じゃなかった");
            yomiageHiretu.Add("よーくこぎな　水が冷たくなるまで");
            yomiageHiretu.Add("おじゃまたくし");
            yomiageHiretu.Add("おとうさんお花屋さんね");
            yomiageHiretu.Add("毛が生えてこんなくちしてて、こんなのとこんくらいのとこーんな大きいのが寝てた");
            yomiageHiretu.Add("こりゃススワタリがでたな");
            yomiageHiretu.Add("塚森へしゅっぱーつ");
            yomiageHiretu.Add("でんぽう留守だからって預かった");
            yomiageHiretu.Add("ほんとだもんほんとにトトロいたんだもんうそじゃないもん");
            yomiageHiretu.Add("まーためいのあしたーがはじまった");
            yomiageHiretu.Add("レンラクコウシチコクヤマ");
            yomiageHiretu.Add("私達かぜになっている");
            yomiageHiretu.Add("おねえちゃんのばーか");
            yomiageHiretu.Add("おねがいめいをさがしてお願い今頃きっとどこかでないてるわ");
            yomiageHiretu.Add("さーつきちゃーん");
            yomiageHiretu.Add("じゃあよるになってもお便所一緒に行ってやんない");
            yomiageHiretu.Add("ととろあなたトトロっていうのね");
            yomiageHiretu.Add("なあにそれトトロだよ");
            yomiageHiretu.Add("マックロクロスケ出ておいで出ないと目玉をほじくるぞ");
            yomiageHiretu.Add("みんな笑ってみな。おっかないのが逃げちゃうからはっはははは");
            yomiageHiretu.Add("ん！");

            int work = -1;

            Console.ReadKey();

            using (SpeechSynthesizer syn = new SpeechSynthesizer())
            {
                syn.Speak("ゲームを開始します。");
                Console.WriteLine("ゲームを開始します");

                //r1.Next(2)
                for (int i = 0; i < 45; i++)
                {
                    syn.Speak("次は" + (i + 1).ToString() + "句目です。");
                    syn.Speak("読み上げます。");
                    work = r1.Next(yomiageHiretu.Count);
                    syn.Speak(yomiageHiretu[work]);
                    Console.WriteLine("★現在" + (i+1).ToString() + "句目です。");
                    syn.Speak("2回目もう一度読み上げます");
                    syn.Speak(yomiageHiretu[work]);
                    Console.WriteLine(yomiageHiretu[work]);
                    yomiageHiretu.RemoveAt(work);

                    Console.ReadKey();
                }

            };
        }
    }
}
