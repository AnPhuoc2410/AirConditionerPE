   M S B A M L   `   `   `  ����X  TAirConditionerShop_AnPhuocDao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:AirConditionerShop_AnPhuocDaoAirConditionerShop_AnPhuocDao  5   	   .    (AirConditionerShop_AnPhuocDao.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:AirConditionerShop_AnPhuocDao     5   	   -   5          � Title$2  ,Thế Giới Điện Tử Xứ F - ver.24-SU��5      $	��685��67   $
��1265��6D      PrimaryBackgroundBrush#��[  5	       � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � Icon$? 9C:\Users\ANPHUOC\Downloads\minecraft_logo_icon_168974.ico��6�   .��5
      � .+�5   
   �� $��Thế Giới Đỏ Đen��6   $
��Left=�6*   $��80��6E   $��	31,20,0,0q�6Q   $	��Top=�5      $	��569��6$   $
��Bold"�60   $��50(�6B   $��Italic$�6P     AccentRedBrush#��[ 5      �� 5   
   $��
ver. 24-SU��6   $
��Left=�6%   $��50��6@   $��
598,40,0,0q�6L   $	��Top=�5      $	��275��6$   $��30(�60   #��[ 6>   $��Italic$�6k   �� 5   
   -   5         ��Name$ HelloMsgLabel��5      $��Hello, Phuoc��6'   $��Right=�6>   $��50��6Z   $��0,6,30,0q�5      $	��Top=�6   $	��315��66   $��25(�6B   $��Italic$�6P   #��[ 5      $��Right=�69   �� 5   
   $
��Left=�6   $��95��6/   $��
39,140,0,0q�6;   ���#000000$	��Top=�5      $
��1171��6(   #��[ 65    �� RadiusX$ 10��6\    �� RadiusY$ 10��6i   �� 5   
   -   5         ��Name$ SearchButton��5      $��Search Air Conditioner��6'   $
��Left=�6H   $��50��6c   $��
75,162,0,0q�5      $	��Top=�6!   $	��262��69     ButtonRedStyle#��[ 6E   6m   �� 5   
   $��Feature Function��6   $
��Left=�6+   $��45��6F   $��388,169,0,0q�6R   $	��Top=�5      $	��152��6$     TextLightBrush#��[ 60   $
��Bold"�6]   �� 5   
   -   5         ��Name$ FeatureFunctionTextBox��5      $
��Left=�62   $��45��6M   $��547,165,0,0q�6Y   $	��Top=�5      $	��303��6&   �� 5!   
   $��Quantity��6   $
��Left=�6#   $��45��6>   $��905,169,0,0q�6J   $	��Top=�5"      $	��108��6$   #��[ 60   $
��Bold"�6]   �� 5#   
   -   5        $ QuantityTextBox��5#      $
��Left=�6+   $��45��6F   $��1003,165,0,0q�6R   $	��Top=�5$      $	��185��6&   �� 5&   
   -   5        $ CreateButton��5&      $��Create Air Con��6'   $
��Left=�6@   $��50��6[   $��1003,294,0,0q�5'      $	��Top=�6#   $	��185��6;   #��[ 6G   6o   �� 5(   
   -   5        $ UpdateButton��5(      $��Update Air Con��6'   $
��Left=�6@   $��50��6[   $��1003,367,0,0q�5)      $	��Top=�6#   $	��185��6;   #��[ 6G   6o   �� 5*   
   -   5        $ DeleteButton��5*      $��Delete Air Con��6'   $
��Left=�6@   $��50��6[   $��1003,444,0,0q�5+      $	��Top=�6#   $	��185��6;   #��[ 6G   6o   �� 5,   
   -	   5        $ 
QuitButton��5,      $
��Quit��6%   $
��Left=�64   $��50��6O   $��1003,540,0,0q�5-      $	��Top=�6#   $	��185��6;     ButtonYellowStyle#��[ 6G   6r   &   System.Windows.Controls.DataGrid  5/   
   -
   5        	  Name$	 AirCondDataGrid��5/      $
��Left=�6,   $	��310��6G   $��
40,289,0,0q�6T   $	��Top=�50      $	��930��6'   
   AutoGenerateColumns$
 False��63   #��[  6O     TextDarkBrush#��[ 51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *AirConditionerId+  54      $ Air Con Name��6%   $	 200 6;    6G   �� *AirConditionerName+  55      $ Warranty��6%   $ 70 67    6B   �� *
Warranty+  56      $ Sound Level��6%   $	 100 6:    6F   �� *SoundPressureLevel+  57      $ Feature Function��6%   $	 200 6?    6K   �� *FeatureFunction+  58      $ Quantity��6%   $ 70 67    6B   �� *
Quantity+  59      $ 	Price ($)��6%   $	 100 68    6D   �� *DollarPrice+  5:      $ Supplier ID��6%   $ 70 6:    6E   �� *
SupplierId+  5;      $ Supplier Name��6%   $	 140 6<    6H   �� *Supplier.SupplierName+5=      �� 5?   
   $��© 2024 an.phuoc��6   $
��Left=�6*   $��45��6E   $��
34,605,0,0q�6Q   $	��Top=�5@      $	��182��6$   #��[ 60   5A      5B      