   M S B A M L   `   `   `  ����B  >FileCSV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FileCSVFileCSV  5   	       FileCSV.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:FileCSV     5   	     � Title$  
MainWindow��5   	   $	��504��6   $
��1351��6)   .��5	      � $��	0,0,34,18q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtMark��5
         AutoGenerateColumns$ False��6#   $��51,89,696,89q�6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 SBD��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Sbd+  5      $
 Toan��6%    63   �� *Toan+  5      $	 Van��6%    62   �� *Van+  5      $ Ly��6%    61   �� *Ly+  5      $
 Sinh��6%    63   �� *Sinh+  5      $ 	Ngoai ngu��6%    68   �� *
Ngoaingu+  5      $
 Year��6%    63   �� *Year+  5      $	 Hoa��6%    62   �� *Hoa+  5      $ Lich su��6%    66   �� *Lichsu+  5      $ Dia ly��6%    65   �� *Dialy+  5      $
 GDCD��6%    63   �� *Gdcd+  5      $ Ma Tinh��6%    66   �� *MaTinh+5      �� 5   
   -   5         ��Name$ btnCalculate��5      $
��Top3��6'   $
��Left=�66   $��
147,30,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ 0.185,-0.123&�6}   �� 5   
   -   5         ��Name$ cbYear��5      $
��Left=�6#   $��
218,32,0,0q�6>   $	��Top=�6R   $��70��6j   $��18��6u   6�   �� 5   
   -   5        	 ��Name$	 txtFile��5      $
��Left=�6#   $��
293,32,0,0q�6>   
 �� TextWrapping$

 Wrap=�6R   $	��Top=�6f   $	��266��6~   �� 5   
   -   5        $ btnInput��5      $��Input��6#   $
��Left=�63   $��
346,55,0,0q�6N   $	��Top=�6b   $��70��6z   6�   �� 5   
   -   5        $ btnClear��5      $��Clear��6#   $
��Left=�63   $��
445,55,0,0q�6N   $	��Top=�6b   $��70��6z   �� 5   
   -   5        $ btnBrowseFile��5      $
��....��6(   $
��Left=�67   $��
564,32,0,0q�6R   $	��Top=�6f   $��18��6~   $��15��6�   6�   �� 5    
   -   5        $ btnShowStatistic��5       $��Show statistics��6+   $
��Left=�6E   $��
683,35,0,0q�6`   $	��Top=�6t   6�   �� 5!   
   -	   5         ��Name$ listView��5!      $��683,89,170,89q�6P    �� View 5"      �� 5#      .P�5$      �� $
��Year��6%    �� DisplayMemberBinding 63   �� *Year+�� 5%      $��StudentCountAtThisYear��6%    6E   �� *StudentCountAtThisYear+�� 5&      $��	CountToan��6%    68   �� *	CountToan+�� 5'      $��CountVan��6%    67   �� *
CountVan+�� 5(      $��CountLy��6%    66   �� *	CountLy+�� 5)      $��	CountSinh��6%    68   �� *	CountSinh+�� 5*      $��CountNgoaiNgu��6%    6<   �� *CountNgoaiNgu+�� 5+      $��CountHoa��6%    67   �� *
CountHoa+�� 5,      $��CountLichSu��6%    6:   �� *CountLichSu+�� 5-      $��
CountDiaLy��6%    69   �� *
CountDiaLy+�� 5.      $��	CountGDCD��6%    68   �� *	CountGDCD+5/      51      54      55      