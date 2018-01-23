using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;using System.Text;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet dataset = new DataSet();
        private string connectString = "data source=localhost; initial catalog = Hive; persist security info=True; user id=BusStationAdmin;password=785412369";
        private List<Label> labels;
        private List<Label> colorLabels;
        public MainWindow()
        {
            InitializeComponent();
            labels = new List<Label> { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].MouseDoubleClick += MouseDoubleClick;
                labels[i].Tag = i;
            }
            colorLabels = new List<Label> { lab1, lab1_1, lab2, lab2_2, lab3, lab3_3, lab4, lab4_4, lab5, lab5_5 };
        }

        private new void MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Label l = (Label)sender;
            Set_Label_Visible((int)l.Tag);
        }

        static Boolean ld = false, nd = false, f = false, r = false, ramkiif = false, shuh_uzif = false, shuh_shif = false, yacheika1 = false, yacheika8, yacheika9, yacheika10, yacheika11, yacheika12, yacheika13, yacheika14, yacheika15, yacheika16, nomerif = true, yacheika2, yacheika3, yacheika4, yacheika5, yacheika6, yacheika7;
        //      static Boolean yacheika1, yacheika8 , yacheika9 , yacheika10, yacheika11, yacheika12 , yacheika13, yacheika14 , yacheika15 , yacheika16 , nomerif = true, yacheika2 , yacheika3 , yacheika4, yacheika5, yacheika6 , yacheika7 ;
        Boolean[] yacheiki = { yacheika1, yacheika2, yacheika3, yacheika4, yacheika5, yacheika6, yacheika7, yacheika8, yacheika9, yacheika10, yacheika11, yacheika12, yacheika13, yacheika14, yacheika15, yacheika16 };
        int kr = 0;
        int korm = 0;
        int dno = 0, condi = 0;
        int id;
        double shuh8 = 0, shuh10 = 0, ramki, shuh8_prom = 0, shuh10_prom = 0, shuh_uz = 0, shuh_sh = 0;
        string last_date, next_date, fam, ras, comm, family, nomer_yacheiki_kr, rasplod, commentarii_vivod;
    //    static Label Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12,Label13, Label14, Label15,Label16;
        

        private void Set_Label_Visible(int nomer)
        {
            for (int i = 0; i < yacheiki.Length; i++)
                yacheiki[i] = false;
            yacheiki[nomer] = true;
            Set_Yacheiki_visibility(Visibility.Visible);
        }

        private void Set_Yacheiki_visibility(Visibility visibility)
        {
            lab1.Visibility = visibility;
            lab1_1.Visibility = visibility;
            lab2.Visibility = visibility;
            lab2_2.Visibility = visibility;
            lab3.Visibility = visibility;
            lab3_3.Visibility = visibility;
            lab4.Visibility = visibility;
            lab4_4.Visibility = visibility;
            lab5.Visibility = visibility;
            lab5_5.Visibility = visibility;
        }

        private void yacheiki_false()
        {
            yacheika1 = false;
            yacheika2 = false;
            yacheika3 = false;
            yacheika4 = false;
            yacheika5 = false;
            yacheika6 = false;
            yacheika7 = false;
            yacheika8 = false;
            yacheika9 = false;
            yacheika10 = false;
            yacheika11 = false;
            yacheika12 = false;
            yacheika13 = false;
            yacheika14 = false;
            yacheika15 = false;
            yacheika16 = false;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)//кнопка назад
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();

        }


        private void lab1_1_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)//крышкиo
        {
            ramkiif = true;
            shuh_shif = true;
            shuh_uzif = true;
          
            if (yacheiki[0] == true)
            {
                kr = kr + 1;
                Label_1.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                kr = kr + 1;
                Label_2.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);

                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                kr = kr + 1;
                Label_3.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                kr = kr + 1;
                Label_4.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                kr = kr + 1;
                Label_5.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                kr = kr + 1;
                Label_6.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                kr = kr + 1;
                Label_7.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                kr = kr + 1;
                Label_8.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                kr = kr + 1;
                Label_9.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                kr = kr + 1;
                Label_10.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                kr = kr + 1;
                Label_11.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                kr = kr + 1;
                Label_12.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                kr = kr + 1;
                Label_13.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                kr = kr + 1;
                Label_14.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                kr = kr + 1;
                Label_15.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                kr = kr + 1;
                Label_16.Background = lab1_1.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;

            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;

        }
        private void lab2_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)//корм
        {


            if (yacheiki[0] == true)
            {
                korm = korm + 1;
                Label_1.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                korm = korm + 1;
                Label_2.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                korm = korm + 1;
                Label_3.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                korm = korm + 1;
                Label_4.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                korm = korm + 1;
                Label_5.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                korm = korm + 1;
                Label_6.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                korm = korm + 1;
                Label_7.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                korm = korm + 1;
                Label_8.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                korm = korm + 1;
                Label_9.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                korm = korm + 1;
                Label_10.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                korm = korm + 1;
                Label_11.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                korm = korm + 1;
                Label_12.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                korm = korm + 1;
                Label_13.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                korm = korm + 1;
                Label_14.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                korm = korm + 1;
                Label_15.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                korm = korm + 1;
                Label_16.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }

            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab3_3_MouseDoubleClick(object sender, MouseButtonEventArgs e)//донья
        {
    

            if (yacheiki[0] == true)
            {
                dno = dno + 1;
                Label_1.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                dno = dno + 1;
                Label_2.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                dno = dno + 1;
                Label_3.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                dno = dno + 1;
                Label_4.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                dno = dno + 1;
                Label_5.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                dno = dno + 1;
                Label_6.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                dno = dno + 1;
                Label_7.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                dno = dno + 1;
                Label_8.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                dno = dno + 1;
                Label_9.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                dno = dno + 1;
                Label_10.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                dno = dno + 1;
                Label_11.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                dno = dno + 1;
                Label_12.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                dno = dno + 1;
                Label_13.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                dno = dno + 1;
                Label_14.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                dno = dno + 1;
                Label_15.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                dno = dno + 1;
                Label_16.Background = lab3_3.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab4_4_MouseDoubleClick(object sender, MouseButtonEventArgs e)//шухлятки 8 рамок
        {
            shuh8_prom = shuh8_prom + 1;

            if (yacheiki[0] == true)
            {
                Label_1.Background = lab4_4.Background;
                Label_2.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                Label_2.Background = lab4_4.Background;
                Label_3.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                Label_3.Background = lab4_4.Background;
                Label_4.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                Label_4.Background = lab4_4.Background;
                Label_5.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                Label_5.Background = lab4_4.Background; Label_6.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                Label_6.Background = lab4_4.Background; Label_7.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                Label_7.Background = lab4_4.Background; Label_8.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                Label_8.Background = lab4_4.Background; Label_9.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                Label_9.Background = lab4_4.Background; Label_10.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                Label_10.Background = lab4_4.Background; Label_11.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                Label_11.Background = lab4_4.Background; Label_12.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                Label_12.Background = lab4_4.Background; Label_13.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                Label_13.Background = lab4_4.Background; Label_14.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                Label_14.Background = lab4_4.Background; Label_15.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                Label_15.Background = lab4_4.Background; Label_16.Background = lab4_4.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                lab11_11.Visibility = Visibility.Visible;
                lab11_11.Text = "Ошибка, Широкие шухлятки должны занимать 2 ячейки";
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab5_5_MouseDoubleClick(object sender, MouseButtonEventArgs e)// шухлятки 10 рамок
        {
            shuh10_prom = shuh10_prom + 1;

            if (yacheiki[0] == true)
            {
                Label_1.Background = lab5_5.Background; Label_2.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();

            }
            if (yacheiki[1] == true)
            {
                Label_2.Background = lab5_5.Background; Label_3.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                Label_3.Background = lab5_5.Background; Label_4.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                Label_4.Background = lab5_5.Background; Label_5.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                Label_5.Background = lab5_5.Background; Label_6.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                Label_6.Background = lab5_5.Background; Label_7.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                Label_7.Background = lab5_5.Background; Label_8.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                Label_8.Background = lab5_5.Background; Label_9.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                Label_9.Background = lab5_5.Background; Label_10.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                Label_10.Background = lab5_5.Background; Label_11.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                Label_11.Background = lab5_5.Background; Label_12.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                Label_12.Background = lab5_5.Background; Label_13.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                Label_13.Background = lab5_5.Background; Label_14.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                Label_14.Background = lab5_5.Background; Label_15.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                Label_15.Background = lab5_5.Background; Label_16.Background = lab5_5.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                lab11_11.Visibility = Visibility.Visible;
                lab11_11.Text = "Ошибка, Широкие шухлятки должны занимать 2 ячейки";
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab_condi_color_MouseDoubleClick(object sender, MouseButtonEventArgs e)//кондиционер
        {
         

            if (yacheiki[0] == true)
            {
                condi = condi + 1;
                Label_1.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                condi = condi + 1;
                Label_2.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                condi = condi + 1;
                Label_3.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                condi = condi + 1;
                Label_4.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                condi = condi + 1;
                Label_5.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                condi = condi + 1;
                Label_6.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                condi = condi + 1;
                Label_7.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                condi = condi + 1;
                Label_8.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                condi = condi + 1;
                Label_9.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                condi = condi + 1;
                Label_10.Background = lab_condi_color.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                condi = condi + 1;
                Label_11.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                condi = condi + 1;
                Label_12.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                condi = condi + 1;
                Label_13.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                condi = condi + 1;
                Label_14.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                condi = condi + 1;
                Label_15.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                condi = condi + 1;
                Label_16.Background = lab2_2.Background;
                Set_Yacheiki_visibility(Visibility.Hidden);
                yacheiki_false();
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "Рамки = " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }


        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }



        private void lab6_6_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void lab7_7_TextChanged(object sender, TextChangedEventArgs e) //дата следующего осмотра
        {
            nd = true;
            next_date = lab7_7.Text;

        }
        private void lab10_1_Click(object sender, RoutedEventArgs e)//рамки
        {
        }
        private void lab9_9_TextChanged(object sender, TextChangedEventArgs e)//расплод
        {
            r = true;
            ras = lab9_9.Text;
        }

        private void lab8_8_TextChanged(object sender, TextChangedEventArgs e)//семейство
        {
            f = true;
            fam = lab7_7.Text;
        }
        private void lab6_6_TextChanged_1(object sender, TextChangedEventArgs e) //дата последнего осмотра
        {

            last_date = lab6_6.Text;
            ld = true;
        }

        private void lab6_6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comment_TextChanged(object sender, TextChangedEventArgs e)
        {
            comm = comment.Text;
        }


  
        private void textbox_TextChanged(object sender, TextChangedEventArgs e) //id по улиям
        {
            uznat_id();
            clean();
            // connect_id(id);
            connect_kr(id);
            connect_korm(id);
            connect_dno(id);
            connect_sh8r(id);
            connect_sh10r(id);
            label_info(id);
            show();
        }


        private void uznat_id()
        {
            String id_text = textbox.Text;
            if (id_text != "")
            {
                id = Convert.ToInt32(id_text);
            }
            else { clean(); }
        }

       private void select_Click(object sender, RoutedEventArgs e)
       {
           clean();
            uznat_id();
           shuh8 = 0; shuh10 = 0; ramki=0; shuh8_prom = 0; shuh10_prom = 0; shuh_uz = 0; shuh_sh = 0; dno = 0; korm = 0;kr = 0; condi = 0;
            lab6_6.Text = "";
            lab7_7.Text = "";
            lab8_8.Text = "";
            lab9_9.Text = "";
            comment.Text = "";
            clean_bd(id);
        }
     
        private void number_u_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }


        private void lab10_10_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private  void clean_bd(int id)
        {
            ld = true;
            nd = true;
            f = true;
            r = true;
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "Update Пчелы Set [дата последнего осмотра] ='',[дата следующего осмотра] = '',семейство = '', рамки = '', крышки = '', донья = '', корм = '', кондиционер = '', внимание = '', расплод = '', [шухлятки узкие]= '',  [шухлятки широкие] = '',[шухлятки 8 рамок]= '', [шухлятки 10 рамок]= '' where id = " + id; 
            SqlCommand command = new SqlCommand(q1, myConnection);
            command.ExecuteNonQuery();
        }
        private void Button1_Click(object sender, RoutedEventArgs e) //обновить бд
        {
            allert.Visibility = Visibility.Visible;
            if (ld == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q1 = "Update Пчелы Set [дата последнего осмотра] = '" + last_date + "' where id = " + id;
                SqlCommand command = new SqlCommand(q1, myConnection);
                command.ExecuteNonQuery();

            }
            if (nd == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q7 = "Update Пчелы Set [дата следующего осмотра] = '" + next_date + "' where id = " + id;
                SqlCommand command = new SqlCommand(q7, myConnection);
                command.ExecuteNonQuery();

            }
            if (f == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q8 = "Update Пчелы Set семейство = '" + fam + "' where id = " + id;
                SqlCommand command = new SqlCommand(q8, myConnection);
                command.ExecuteNonQuery();

            }
            if (r == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q9 = "Update Пчелы Set расплод = '" + ras + "' where id = " + id;
                SqlCommand command = new SqlCommand(q9, myConnection);
                command.ExecuteNonQuery();

            }

            if (Label_1.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q2 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q2, myConnection);
                command.ExecuteNonQuery();


            }
            if (Label_1.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q3 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q3, myConnection);
                command.ExecuteNonQuery();


            }
            if (Label_1.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q4 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q4, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q5 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q5, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab1_1.Background)// вторая ячейка крышки
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q13 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q13, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q14 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q14, myConnection);
                command.ExecuteNonQuery();


            }
            if (Label_2.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q15 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q15, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q16 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q16, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q17 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q17, myConnection);
                command.ExecuteNonQuery();

            }
            if (Label_2.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q18 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q18, myConnection);
                command.ExecuteNonQuery();


            }
            if (Label_3.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q19 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q19, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q20 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q20, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q21 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q21, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q22 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q22, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q23 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q23, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q24 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q24, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q25 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q25, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q26 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q26, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q27 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q27, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q28 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q28, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q29 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q29, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q30 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q30, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q30 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q30, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q31 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q31, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q32 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q32, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q33 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q33, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q34 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q34, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q35 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q35, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q36 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q36, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q37 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q37, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q38 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q38, myConnection);
                command.ExecuteNonQuery();

            }
            if (Label_7.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q39 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q39, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q40 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q40, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab5_5.Background)
            {
                shuh10 = shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q41 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q41, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q42 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q42, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q43 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q43, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q44 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q44, myConnection);
                command.ExecuteNonQuery();

            }
            if (Label_8.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q45 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q45, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q46 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q46, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q47 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q47, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q48 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q48, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q49 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q49, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q50 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q50, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q51 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q51, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q52 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q52, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q53 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q53, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q54 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q54, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q55 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q55, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q56 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q56, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q57 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q57, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q58 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q58, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q59 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q59, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q60 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q60, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q61 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q61, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q62 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q62, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q63 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q63, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q64 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q64, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q65 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q65, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q66 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q66, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q67 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q67, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q68 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q68, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q69 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q69, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q70 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q70, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q71 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q71, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q72 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q72, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q73 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q73, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q74 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q74, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q75 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q75, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q76 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q76, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q77 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q77, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q78 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q78, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q79 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q79, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q80 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q80, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q81 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q81, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab1_1.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q82 = "Update Пчелы Set крышки =" + kr + " where id=" + id;
                SqlCommand command = new SqlCommand(q82, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab2_2.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q83 = "Update Пчелы Set корм =" + korm + " where id=" + id;
                SqlCommand command = new SqlCommand(q83, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab3_3.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q84 = "Update Пчелы Set донья =" + dno + " where id=" + id;
                SqlCommand command = new SqlCommand(q84, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q85 = "Update Пчелы Set [шухлятки 8 рамок] =" + shuh8 + " where id=" + id;
                SqlCommand command = new SqlCommand(q85, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab5_5.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q86 = "Update Пчелы Set [шухлятки 10 рамок] =" + shuh10 + " where id=" + id;
                SqlCommand command = new SqlCommand(q86, myConnection);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab_condi_color.Background)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q6 = "Update Пчелы Set [кондиционер] =" + condi + " where id=" + id;
                SqlCommand command = new SqlCommand(q6, myConnection);
                command.ExecuteNonQuery();
            }
            if (ramkiif == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q10 = "Update Пчелы Set рамки =" + ramki + " where id=" + id;
                SqlCommand command = new SqlCommand(q10, myConnection);
                command.ExecuteNonQuery();
            }
            if (shuh_uzif == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q11 = "Update Пчелы Set [шухлятки узкие] =" + shuh_uz + " where id=" + id;
                SqlCommand command = new SqlCommand(q11, myConnection);
                command.ExecuteNonQuery();
            }
            if (shuh_shif == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q12 = "Update Пчелы Set [шухлятки широкие] =" + shuh_sh + " where id=" + id;
                SqlCommand command = new SqlCommand(q12, myConnection);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)    
            {
                String nomer_yacheiki_kr="0";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q87 = "Update Пчелы Set [номер ячейки крышки] ='" + podschet_yacheiki_kr(nomer_yacheiki_kr)+ "' where id=" + id;
                SqlCommand command = new SqlCommand(q87, myConnection);
                command.ExecuteNonQuery();       
            }
            if (nomerif == true)

            {
                String nomer_yacheiki_korm = "0";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q88 = "Update Пчелы Set [номер ячейки корм] ='" + podschet_yacheiki_korm(nomer_yacheiki_korm) + "' where id=" + id;
                SqlCommand command = new SqlCommand(q88, myConnection);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)
            {
                String nomer_yacheiki_dno = "0";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q89 = "Update Пчелы Set [номер ячейки дно] ='" + podschet_yacheiki_dno(nomer_yacheiki_dno) + "' where id=" + id;
                SqlCommand command = new SqlCommand(q89, myConnection);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)
            {
                String nomer_yacheiki_sh8r = "0";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q90 = "Update Пчелы Set [номер ячейки ш8р] ='" + podschet_yacheiki_sh8r(nomer_yacheiki_sh8r) + "' where id=" + id;
                SqlCommand command = new SqlCommand(q90, myConnection);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)
            {
                String nomer_yacheiki_sh10r = "0";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q91 = "Update Пчелы Set [номер ячейки ш10р] ='" + podschet_yacheiki_sh10r(nomer_yacheiki_sh10r) + "' where id=" + id;
                SqlCommand command = new SqlCommand(q91, myConnection);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string q92 = "Update Пчелы Set [комментарии] ='" + comm + "' where id=" + id;
                SqlCommand command = new SqlCommand(q92, myConnection);
                command.ExecuteNonQuery();
            }
        }
        private string podschet_yacheiki_kr(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab1_1.Background)
            {
                nomer_yacheiki = "1";
            }
          
            if (Label_2.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+ ",2";
            }
           
            if (Label_3.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",3";
            }
            
            if (Label_4.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",4";
            }
           
            if (Label_5.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",5";
            }
          
            if (Label_6.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",6";
            }
            
            if (Label_7.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",7";
            }
          
            if (Label_8.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",8";
            }
           
            if (Label_9.Background == lab1_1.Background)
            {
                nomer_yacheiki = nomer_yacheiki+",9";
            }
          
            if (Label_10.Background == lab0.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",10";
            }
         
            if (Label_11.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",11";
            }
          
            if (Label_12.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",12";
            }
          
            if (Label_13.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",13";
            }
          
            if (Label_14.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",14";
            }
           
            if (Label_15.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",15";
            }
      
            if (Label_16.Background == lab1.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_korm(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab2_2.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_dno(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab3_3.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_sh8r(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab4_4.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_sh10r(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab5_5.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        public void show()
        {
            Label_1.Visibility = Visibility.Visible;
            Label_2.Visibility = Visibility.Visible;
            Label_3.Visibility = Visibility.Visible;
            Label_4.Visibility = Visibility.Visible;
            Label_5.Visibility = Visibility.Visible;
            Label_6.Visibility = Visibility.Visible;
            Label_7.Visibility = Visibility.Visible;
            Label_8.Visibility = Visibility.Visible;
            Label_9.Visibility = Visibility.Visible;
            Label_10.Visibility = Visibility.Visible;
            Label_11.Visibility = Visibility.Visible;
            Label_12.Visibility = Visibility.Visible;
            Label_13.Visibility = Visibility.Visible;
            Label_14.Visibility = Visibility.Visible;
            Label_15.Visibility = Visibility.Visible;
            Label_16.Visibility = Visibility.Visible;
        }
        public void hide()
        {
            Label_1.Visibility = Visibility.Hidden;
            Label_2.Visibility = Visibility.Hidden;
            Label_3.Visibility = Visibility.Hidden;
            Label_4.Visibility = Visibility.Hidden;
            Label_5.Visibility = Visibility.Hidden;
            Label_6.Visibility = Visibility.Hidden;
            Label_7.Visibility = Visibility.Hidden;
            Label_8.Visibility = Visibility.Hidden;
            Label_9.Visibility = Visibility.Hidden;
            Label_10.Visibility = Visibility.Hidden;
            Label_11.Visibility = Visibility.Hidden;
            Label_12.Visibility = Visibility.Hidden;
            Label_13.Visibility = Visibility.Hidden;
            Label_14.Visibility = Visibility.Hidden;
            Label_15.Visibility = Visibility.Hidden;
            Label_16.Visibility = Visibility.Hidden;
        }
        public string opredelit_nomer_krishki(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab1_1.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_korm(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab2_2.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_dno(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab3_3.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh8r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab4_4.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh10r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab5_5.Background;
            }
            return nomer_krishki_1;
        }
        public void connect_fam(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [семейство] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    family = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
        }
        public void connect_last_date(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [дата последнего осмотра] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    last_date = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
        }
        public void connect_next_date(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [дата следующего осмотра] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    next_date = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
        }
        public void connect_kr(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [номер ячейки крышки] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_krishki(nomer_kr[i]);

            }

        }
        public void connect_korm(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [номер ячейки корм] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_korm(nomer_kr[i]);

            }

        }
        public void connect_dno(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [номер ячейки дно] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_dno(nomer_kr[i]);

            }


        }
        public void connect_sh8r(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [номер ячейки ш8р] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh8r(nomer_kr[i]);

            }
        }
        public void connect_sh10r(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [номер ячейки ш10р] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh10r(nomer_kr[i]);

            }
        }
        public void clean()
        {
            Label_1.Background = no_color.Background;
            Label_2.Background = no_color.Background;
            Label_3.Background = no_color.Background;
            Label_4.Background = no_color.Background;
            Label_5.Background = no_color.Background;
            Label_6.Background = no_color.Background;
            Label_7.Background = no_color.Background;
            Label_8.Background = no_color.Background;
            Label_9.Background = no_color.Background;
            Label_10.Background = no_color.Background;
            Label_11.Background = no_color.Background;
            Label_12.Background = no_color.Background;
            Label_13.Background = no_color.Background;
            Label_14.Background = no_color.Background;
            Label_15.Background = no_color.Background;
            Label_16.Background = no_color.Background;
        }
        public void label_info(int id)
        {
            connect_fam(id);
            connect_last_date(id);
            connect_next_date(id);
            rasplod_info(id);
            comment_info(id);
            lab6_6.Text = last_date;
            lab7_7.Text = next_date;
            lab8_8.Text = family;
            lab9_9.Text = rasplod;
            comment.Text = commentarii_vivod;
        }
        public void rasplod_info(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [расплод] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    rasplod = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
        }
        public void comment_info(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string q1 = "SELECT [комментарии] FROM Пчелы where id = " + id;
            SqlCommand command = new SqlCommand(q1, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    commentarii_vivod = Convert.ToString(reader[0]);
                }
            }
            finally { myConnection.Close(); }
        }
    }

}

