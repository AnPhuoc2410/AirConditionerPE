   M S B A M L   `   `   `  ����X  TAirConditionerShop_AnPhuocDao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:AirConditionerShop_AnPhuocDaoAirConditionerShop_AnPhuocDao  5   	   0    *AirConditionerShop_AnPhuocDao.DetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:AirConditionerShop_AnPhuocDao     5   	   -   5          � Title$  Air Conditioner Detail��5      $	��755��6,   $
��1150��69      PrimaryBackgroundBrush#��[  5	       � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � Icon$? 9C:\Users\ANPHUOC\Downloads\minecraft_logo_icon_168974.ico��6u   .��5
      � .+�5   
   �� -   5         ��Name$ DetailWindowMode��5      $%��Create | Update Air Conditioner��6*   $
��Left=�5      $��80��6'   $��	38,20,0,0q�63   $	��Top=�5      $	��814��6$   $
��Bold"�60   $��40(�6B   $��Italic$�5        AccentRedBrush#��[ 6   �� 5   
   $
��Left=�6   $	��565��6/   $��
38,128,0,0q�6<   ���#000000$	��Top=�5   !   $	��875��69   #��[ 5       �� RadiusX$ 10��67    �� RadiusY$ 10��6D   �� 5   
   $��
Air Con ID��6   $
��Left=�6%   $��45��6@   $��
58,155,0,0q�6L   $	��Top=�5      $	��107��6$     TextLightBrush#��[ 60   �� 5   
   -   5         ��Name$ AirConditionerIdTextBox��5      $
��Left=�63   $��45��6N   $��223,153,0,0q�5      $	��Top=�6#   $	��275��6;   $��0��6G   �� 5   
   $��Air Con Name��6   $
��Left=�6'   $��45��6B   $��
58,218,0,0q�6N   $	��Top=�5      $	��147��6$   #��[ 60   �� 5   
   -   5        $ AirConditionerNameTextBox��5      $
��Left=�65   $��45��6P   $��223,216,0,0q�5      $	��Top=�6#   $	��635��6;   $��1��6G   �� 5   
   $��Warranty��6   $
��Left=�6#   $��45��6>   $��
58,284,0,0q�6J   $	��Top=�5      $	��107��6$   #��[ 60   �� 5    
   -   5        $ WarrantyTextBox��5       $
��Left=�6+   $��45��6F   $��223,283,0,0q�5!      $	��Top=�6#   $	��635��6;   $��2��6G   �� 5#   
   $��Sound Level��6   $
��Left=�6&   $��45��6A   $��
58,351,0,0q�6M   $	��Top=�5$      $	��128��6$   #��[ 60   �� 5%   
   -   5        $ SoundPressureLevelTextBox��5%      $
��Left=�65   $��45��6P   $��223,351,0,0q�5&      $	��Top=�6#   $	��635��6;   $��3��6G   �� 5(   
   $��Feature Function��6   $
��Left=�6+   $��45��6F   $��
58,422,0,0q�6R   $	��Top=�5)      $	��157��6$   #��[ 60   �� 5*   
   -   5        $ FeatureFunctionTextBox��5*      $
��Left=�62   $	��105��6M   $��223,421,0,0q�5+      $	��Top=�6#   $	��637��6;   $��4��6G    �� AcceptsReturn$
 True��5,      "	 �� VerticalScrollBarVisibility$	 Visible=�6#   $	��Top=�5-      �� 5/   
   $��Quantity��6   $
��Left=�6#   $��45��6>   $��
58,550,0,0q�6J   $	��Top=�50      $	��140��6$   #��[ 60   �� 51   
   -   5        $ QuantityTextBox��51      $
��Left=�6+   $��45��6F   $��223,547,0,0q�52      $	��Top=�6#   $	��227��6;   $��5��6G   �� 54   
   $��	Price ($)��6   $
��Left=�6$   $��45��6?   $��516,552,0,0q�6K   $	��Top=�55      $	��107��6$   #��[ 60   �� 56   
   -	   5        $ DollarPriceTextBox��56      $
��Left=�6.   $��45��6I   $��615,549,0,0q�57      $	��Top=�6#   $	��244��6;   $��6��6G   �� 59   
   $��Supplier ID��6   $
��Left=�6&   $��45��6A   $��
58,615,0,0q�6M   $	��Top=�5:      $	��147��6$   #��[ 60   �� 5;   
   -
   5        
 ��Name$
 SupplierIdComboBox��5;      $
��Left=�6/   $��45��6J   $��223,613,0,0q�5<      $	��Top=�6%   $	��290��6=   #��[ 5=      $��7��6=   $
��Bold"�5>      $��18(�6"   �� 5@   
   -   5         ��Name$ 
SaveButton��5@      $��Save Air Con��6%   $
��Left=�6<   $��50��6W   $��945,128,0,0q�5A      $	��Top=�6"   $	��165��6:     ButtonRedStyle#��[ 5B      $��8��65   6B   �� 5C   
   -   5        $ CloseButton��5C      $��Close��6&   $
��Left=�66   $��50��6Q   $��945,208,0,0q�5D      $	��Top=�6"   $	��165��6:     ButtonYellowStyle#��[ 5E      $��9��68   6E   5F      5G      