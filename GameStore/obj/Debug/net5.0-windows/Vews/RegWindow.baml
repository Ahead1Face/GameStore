   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GameStore.VewsGameStore.Vews  5   	       GameStore.Vews.RegWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GameStore.Vews     5   	   -   5          �Name$  rw��5   	    � Title$ 	RegWindow��5	   	   $	��450��6   $	��800��6(    � 
ResizeMode$ NoResize=�64    � WindowStyle$
 None=�6J    � WindowStartupLocation$ CenterScreen=�6]   .��5      � -   5         �Name$ Grid1��5       � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��500* �6   .+�5   
   � $��1��6   ��5      �� 5       
  LogoG2 �� ImageSource# [  6    5      �� 5      $	��30* �6    �� 5      $	��45* �6    �� 5      $	��25* �6    �� 5      $	��45* �6    �� 5      $	��25* �6    �� 5      $	��44* �6    �� 5      $	��25* �6    �� 5      $	��45* �6    �� 5      $	��30* �6    �� 5      $	��40* �6    �� 5       $	��21* �6     � ColumnDefinitions 5"      �� 5#      $	��70* �6#   �� 5$      $
��270* �6#   �� 5%      $
��440* �6#   .+�5'      �� -   5        	 ��Name$	 TBLogin��5'      $��1��6'   $��1��64   $��Center=�6D   $��16(�6f   
�������
 � Cursor$
 Arrow��6�   ��5(      �� *NewUserLogin+6%   �� 5)      -   5        $	 TBEmail��5)      $��3��6(   $��1��65   $��Center=�6E   $��16(�6g   
�������$
 Arrow��6�   ��5*      �� *NewUserEmail+6%   G� 5+      -   5         G�Name$	 pb1��5+      $��1��6   $��5��6.   $��Center=�6;   $��16(�6]   6k   � 5,      $��9��6
   $��1��6    5-      �� 5.      $
��100* �6'   �� 5/      $	��30* �6'   �� 50      $
��100* �6'   .+�52      �� -   5         ��Name$ B_Back��52      $��0��6)   $��
Назад��69   ��53      �� *ChangeToMainWindow+�� 54      $��2��6   $��Регистрация��6)   ��6?   �� *
AddNewUser+��6^   ��  �� ElementName$	 pb1��55      56      57      58      