﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Smart_Challenge
{
    public partial class s7lvl19 : PhoneApplicationPage
    {
        public s7lvl19()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ora apri il forziere inserendo il codice al contrario";

            }
            else
            {
                Instr.Text = "Now open the chest by inserting the code to the contrary";
            }
        }


        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show(VarGlobal.text2, VarGlobal.text1, MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.Cancel)
            {
                //SE L'UTENTE ANNULLA ALLORA BLOCCO LA FUNZIONE DEL TASTO INDIETRO
                e.Cancel = true;
            }
            else
            {
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void numPad(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image lol = (Image)sender;
            calc1.Text += lol.Name.Substring(1);

        }

        private void numPad0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (calc1.Text == "1469")
                NavigationService.Navigate(new Uri("/lvlSet7/s7lvl20.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
      
    }
}