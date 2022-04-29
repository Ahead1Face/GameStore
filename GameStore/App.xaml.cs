using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GameStore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowBuilder.ShowMainWondow();
            InitDB();
            base.OnStartup(e);
            
        }

        void InitDB()
        {
            try
            {
                using(DBStore db = new DBStore())
                {
                    db.Database.Initialize(false);

                    if(db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        string imagesPath = @"Images\Game\";

                        Game ACV = new Game(1, "Assassin's creed valhalla", 2990, imagesPath + "AC_Valhalla.jpg");
                        db.Game.Add(ACV);
                        Game CS = new Game(1, "Counter-strike global offensive", 1200, imagesPath + "CSGO.jpg");
                        db.Game.Add(CS);
                        Game CyberPunk = new Game(1, "CyberPunk 2077", 2000, imagesPath + "Cyberpunk-2077.jpg");
                        db.Game.Add(CyberPunk);
                        Game MK11 = new Game(1, "Mortal Konbat 11", 1500, imagesPath + "Mortal_Kombat_11.jpg");
                        db.Game.Add(MK11);
                        Game FH5 = new Game(1, "Forza Horizon 5", 3550, imagesPath + "Forza_Horizon_5.jpg");
                        db.Game.Add(FH5);

                        User VVS = new User(1, "VVS", "VVS@mail.ru", "Geroin3412");
                        db.User.Add(VVS);
                        User AAN = new User(1, "AAN", "AAN@mail.ru", "Kolyn4912");
                        db.User.Add(AAN);

                        VVS.Games.Add(FH5);
                        VVS.Games.Add(MK11);
                        AAN.Games.Add(CS);
                        AAN.Games.Add(CyberPunk);

                        db.SaveChanges();
                    }
                }
            }
            catch(Exception el)
            {
                MessageBox.Show($"Ошибка инициализации БД: {el.Message}");
            }
        }
    }
}
