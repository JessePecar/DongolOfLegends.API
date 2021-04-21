using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongolOfLegends.API.Models.Models.Champions
{
    [NotMapped]
    public class ChampionData
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("Aatrox")]
        public Aatrox Aatrox { get; set; }
        
        [JsonProperty("Ahri")]
        public Ahri Ahri { get; set; }

        [JsonProperty("Akali")]
        public Akali Akali { get; set; }

        [JsonProperty("Alistar")]
        public Alistar Alistar { get; set; }

        [JsonProperty("Amumu")]
        public Amumu Amumu { get; set; }

        [JsonProperty("Anivia")]
        public Anivia Anivia { get; set; }

        [JsonProperty("Annie")]
        public Annie Annie { get; set; }

        [JsonProperty("Aphelios")]
        public Aphelios Aphelios { get; set; }

        [JsonProperty("Ashe")]
        public Ashe Ashe { get; set; }

        [JsonProperty("AurelionSol")]
        public AurelionSol AurelionSol { get; set; }

        [JsonProperty("Azir")]
        public Azir Azir { get; set; }

        [JsonProperty("Bard")]
        public Bard Bard { get; set; }

        [JsonProperty("Blitzcrank")]
        public Blitzcrank Blitzcrank { get; set; }

        [JsonProperty("Brand")]
        public Brand Brand { get; set; }

        [JsonProperty("Braum")]
        public Braum Braum { get; set; }

        [JsonProperty("Caitlyn")]
        public Caitlyn Caitlyn { get; set; }

        [JsonProperty("Camille")]
        public Camille Camille { get; set; }

        [JsonProperty("Cassiopeia")]
        public Cassiopeia Cassiopeia { get; set; }

        [JsonProperty("Chogath")]
        public Chogath Chogath { get; set; }

        [JsonProperty("Corki")]
        public Corki Corki { get; set; }

        [JsonProperty("Darius")]
        public Darius Darius { get; set; }

        [JsonProperty("Diana")]
        public Diana Diana { get; set; }

        [JsonProperty("Draven")]
        public Draven Draven { get; set; }

        [JsonProperty("DrMundo")]
        public DrMundo DrMundo { get; set; }

        [JsonProperty("Ekko")]
        public Ekko Ekko { get; set; }

        [JsonProperty("Elise")]
        public Elise Elise { get; set; }

        [JsonProperty("Evelynn")]
        public Evelynn Evelynn { get; set; }

        [JsonProperty("Ezreal")]
        public Ezreal Ezreal { get; set; }

        [JsonProperty("Fiddlesticks")]
        public Fiddlesticks Fiddlesticks { get; set; }

        [JsonProperty("Fiora")]
        public Fiora Fiora { get; set; }

        [JsonProperty("Fizz")]
        public Fizz Fizz { get; set; }

        [JsonProperty("Galio")]
        public Galio Galio { get; set; }

        [JsonProperty("Gangplank")]
        public Gangplank Gangplank { get; set; }

        [JsonProperty("Garen")]
        public Garen Garen { get; set; }

        [JsonProperty("Gnar")]
        public Gnar Gnar { get; set; }

        [JsonProperty("Gragas")]
        public Gragas Gragas { get; set; }

        [JsonProperty("Graves")]
        public Graves Graves { get; set; }

        [JsonProperty("Gwen")]
        public Graves Gwen { get; set; }

        [JsonProperty("Hecarim")]
        public Hecarim Hecarim { get; set; }

        [JsonProperty("Heimerdinger")]
        public Heimerdinger Heimerdinger { get; set; }

        [JsonProperty("Illaoi")]
        public Illaoi Illaoi { get; set; }

        [JsonProperty("Irelia")]
        public Irelia Irelia { get; set; }

        [JsonProperty("Ivern")]
        public Ivern Ivern { get; set; }

        [JsonProperty("Janna")]
        public Janna Janna { get; set; }

        [JsonProperty("JarvanIV")]
        public JarvanIV JarvanIV { get; set; }

        [JsonProperty("Jax")]
        public Jax Jax { get; set; }

        [JsonProperty("Jayce")]
        public Jayce Jayce { get; set; }

        [JsonProperty("Jhin")]
        public Jhin Jhin { get; set; }

        [JsonProperty("Jinx")]
        public Jinx Jinx { get; set; }

        [JsonProperty("Kaisa")]
        public Kaisa Kaisa { get; set; }

        [JsonProperty("Kalista")]
        public Kalista Kalista { get; set; }

        [JsonProperty("Karma")]
        public Karma Karma { get; set; }

        [JsonProperty("Karthus")]
        public Karthus Karthus { get; set; }

        [JsonProperty("Kassadin")]
        public Kassadin Kassadin { get; set; }

        [JsonProperty("Katarina")]
        public Katarina Katarina { get; set; }

        [JsonProperty("Kayle")]
        public Kayle Kayle { get; set; }

        [JsonProperty("Kayn")]
        public Kayn Kayn { get; set; }

        [JsonProperty("Kennen")]
        public Kennen Kennen { get; set; }

        [JsonProperty("Khazix")]
        public Khazix Khazix { get; set; }

        [JsonProperty("Kindred")]
        public Kindred Kindred { get; set; }

        [JsonProperty("Kled")]
        public Kled Kled { get; set; }

        [JsonProperty("KogMaw")]
        public KogMaw KogMaw { get; set; }

        [JsonProperty("Leblanc")]
        public Leblanc Leblanc { get; set; }

        [JsonProperty("LeeSin")]
        public LeeSin LeeSin { get; set; }

        [JsonProperty("Leona")]
        public Leona Leona { get; set; }

        [JsonProperty("Lillia")]
        public Lillia Lillia { get; set; }

        [JsonProperty("Lissandra")]
        public Lissandra Lissandra { get; set; }

        [JsonProperty("Lucian")]
        public Lucian Lucian { get; set; }

        [JsonProperty("Lulu")]
        public Lulu Lulu { get; set; }

        [JsonProperty("Lux")]
        public Lux Lux { get; set; }

        [JsonProperty("Malphite")]
        public Malphite Malphite { get; set; }

        [JsonProperty("Malzahar")]
        public Malzahar Malzahar { get; set; }

        [JsonProperty("Maokai")]
        public Maokai Maokai { get; set; }

        [JsonProperty("MasterYi")]
        public MasterYi MasterYi { get; set; }

        [JsonProperty("MissFortune")]
        public MissFortune MissFortune { get; set; }

        [JsonProperty("MonkeyKing")]
        public MonkeyKing MonkeyKing { get; set; }

        [JsonProperty("Mordekaiser")]
        public Mordekaiser Mordekaiser { get; set; }

        [JsonProperty("Morgana")]
        public Morgana Morgana { get; set; }

        [JsonProperty("Nami")]
        public Nami Nami { get; set; }

        [JsonProperty("Nasus")]
        public Nasus Nasus { get; set; }

        [JsonProperty("Nautilus")]
        public Nautilus Nautilus { get; set; }

        [JsonProperty("Neeko")]
        public Neeko Neeko { get; set; }

        [JsonProperty("Nidalee")]
        public Nidalee Nidalee { get; set; }

        [JsonProperty("Nocturne")]
        public Nocturne Nocturne { get; set; }

        [JsonProperty("Nunu")]
        public Nunu Nunu { get; set; }

        [JsonProperty("Olaf")]
        public Olaf Olaf { get; set; }

        [JsonProperty("Orianna")]
        public Orianna Orianna { get; set; }

        [JsonProperty("Ornn")]
        public Ornn Ornn { get; set; }

        [JsonProperty("Pantheon")]
        public Pantheon Pantheon { get; set; }

        [JsonProperty("Poppy")]
        public Poppy Poppy { get; set; }

        [JsonProperty("Pyke")]
        public Pyke Pyke { get; set; }

        [JsonProperty("Qiyana")]
        public Qiyana Qiyana { get; set; }

        [JsonProperty("Quinn")]
        public Quinn Quinn { get; set; }

        [JsonProperty("Rakan")]
        public Rakan Rakan { get; set; }

        [JsonProperty("Rammus")]
        public Rammus Rammus { get; set; }

        [JsonProperty("RekSai")]
        public RekSai RekSai { get; set; }

        [JsonProperty("Rell")]
        public Rell Rell { get; set; }

        [JsonProperty("Renekton")]
        public Renekton Renekton { get; set; }

        [JsonProperty("Rengar")]
        public Rengar Rengar { get; set; }

        [JsonProperty("Riven")]
        public Riven Riven { get; set; }

        [JsonProperty("Rumble")]
        public Rumble Rumble { get; set; }

        [JsonProperty("Ryze")]
        public Ryze Ryze { get; set; }

        [JsonProperty("Samira")]
        public Samira Samira { get; set; }

        [JsonProperty("Sejuani")]
        public Sejuani Sejuani { get; set; }

        [JsonProperty("Senna")]
        public Senna Senna { get; set; }

        [JsonProperty("Seraphine")]
        public Seraphine Seraphine { get; set; }

        [JsonProperty("Sett")]
        public Sett Sett { get; set; }

        [JsonProperty("Shaco")]
        public Shaco Shaco { get; set; }

        [JsonProperty("Shen")]
        public Shen Shen { get; set; }

        [JsonProperty("Shyvana")]
        public Shyvana Shyvana { get; set; }

        [JsonProperty("Singed")]
        public Singed Singed { get; set; }

        [JsonProperty("Sion")]
        public Sion Sion { get; set; }

        [JsonProperty("Sivir")]
        public Sivir Sivir { get; set; }

        [JsonProperty("Skarner")]
        public Skarner Skarner { get; set; }

        [JsonProperty("Sona")]
        public Sona Sona { get; set; }

        [JsonProperty("Soraka")]
        public Soraka Soraka { get; set; }

        [JsonProperty("Swain")]
        public Swain Swain { get; set; }

        [JsonProperty("Sylas")]
        public Sylas Sylas { get; set; }

        [JsonProperty("Syndra")]
        public Syndra Syndra { get; set; }

        [JsonProperty("TahmKench")]
        public TahmKench TahmKench { get; set; }

        [JsonProperty("Taliyah")]
        public Taliyah Taliyah { get; set; }

        [JsonProperty("Talon")]
        public Talon Talon { get; set; }

        [JsonProperty("Taric")]
        public Taric Taric { get; set; }

        [JsonProperty("Teemo")]
        public Teemo Teemo { get; set; }

        [JsonProperty("Thresh")]
        public Thresh Thresh { get; set; }

        [JsonProperty("Tristana")]
        public Tristana Tristana { get; set; }

        [JsonProperty("Trundle")]
        public Trundle Trundle { get; set; }

        [JsonProperty("Tryndamere")]
        public Tryndamere Tryndamere { get; set; }

        [JsonProperty("TwistedFate")]
        public TwistedFate TwistedFate { get; set; }

        [JsonProperty("Twitch")]
        public Twitch Twitch { get; set; }

        [JsonProperty("Udyr")]
        public Udyr Udyr { get; set; }

        [JsonProperty("Urgot")]
        public Urgot Urgot { get; set; }

        [JsonProperty("Varus")]
        public Varus Varus { get; set; }

        [JsonProperty("Vayne")]
        public Vayne Vayne { get; set; }

        [JsonProperty("Veigar")]
        public Veigar Veigar { get; set; }

        [JsonProperty("Velkoz")]
        public Velkoz Velkoz { get; set; }

        [JsonProperty("Vi")]
        public Vi Vi { get; set; }

        [JsonProperty("Viego")]
        public Viego Viego { get; set; }

        [JsonProperty("Viktor")]
        public Viktor Viktor { get; set; }

        [JsonProperty("Vladimir")]
        public Vladimir Vladimir { get; set; }

        [JsonProperty("Volibear")]
        public Volibear Volibear { get; set; }

        [JsonProperty("Warwick")]
        public Warwick Warwick { get; set; }

        [JsonProperty("Xayah")]
        public Xayah Xayah { get; set; }

        [JsonProperty("Xerath")]
        public Xerath Xerath { get; set; }

        [JsonProperty("XinZhao")]
        public XinZhao XinZhao { get; set; }

        [JsonProperty("Yasuo")]
        public Yasuo Yasuo { get; set; }

        [JsonProperty("Yone")]
        public Yone Yone { get; set; }

        [JsonProperty("Yorick")]
        public Yorick Yorick { get; set; }

        [JsonProperty("Yuumi")]
        public Yuumi Yuumi { get; set; }

        [JsonProperty("Zac")]
        public Zac Zac { get; set; }

        [JsonProperty("Zed")]
        public Zed Zed { get; set; }

        [JsonProperty("Ziggs")]
        public Ziggs Ziggs { get; set; }

        [JsonProperty("Zilean")]
        public Zilean Zilean { get; set; }

        [JsonProperty("Zoe")]
        public Zoe Zoe { get; set; }

        [JsonProperty("Zyra")]
        public Zyra Zyra { get; set; }
    }



}
