   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GameStore	GameStore  5   	       GameStore.Vews.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GameStore     5   	   -   5          �Name$  mw��5   	    � Title$ 
MainWindow��5
   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�6K    � WindowStartupLocation$ CenterScreen=�6^   .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��500* �6   .+�5   
   � $��1��6   ��5      �� 5       
  LogoVP �� ImageSource# [  6    5      �� 5      $	��70* �6    �� 5      $	��45* �6    �� 5      $	��40* �6    �� 5      $	��45* �6    �� 5      $	��80* �6    �� 5      $	��40* �6    �� 5      $	��40* �6     � ColumnDefinitions 5      �� 5      $	��70* �6#   �� 5      $
��270* �6#   �� 5       $
��440* �6#   .+�5"      �� -   5        	 ��Name$	 TBLogin��5"      $��1��5#      $��1��5$      ���	#FF3B3A53$��14(�5&      
 � Cursor$
 Arrow��5'      $��Center=�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5)       ! MaterialDesignOutlinedTextBox#��[ 5,      ��5+      �� *CurrentUserLogin+ �� UpdateSourceTrigger$ PropertyChanged=�5,      G� 5/      -   5         G�Name$ 
pbPassword��5/      $��2��51      $��1��52      ���	#FF3B3A53$��14(�54      $
 Arrow��55      $��Center=�56      $ Пароль��57       # MaterialDesignFilledPasswordBox#��[ 58      $��2��59      $
��Left=�5:      $��0,45,0,0q�5;      $��2��6$   $	��277��5<      � 5>      $��5��6   $��1��6     5?      �� 5@      $
��100* �6'   �� 5A      $	��30* �6'   �� 5B      $
��100* �6'   .+�5D      �� -   5         ��Name$ bLogin��5D      $��0��5E      $��
ВОЙТИ��5F      $��Center=�5G      $��12(�5H      ��5I      �� *	LoginUser+��5J      ��  �� ElementName$ 
pbPassword���� 5M      -   5        $
 bReg��5M      $��2��5N      $��РЕГИСТРАЦИЯ��5O      $��Center=�5P      $��12(�5Q      ��5R      �� *ChangeToRegWindow+5U      5V      5W      5X      