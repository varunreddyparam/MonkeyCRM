   M S B A M L   `   `   `  ����D  @MonkeyCRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MonkeyCRM	MonkeyCRM  5   	       MonkeyCRM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MonkeyCRM     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � ShowInTaskbar  .   � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`    � WindowStyle$
 None=�6�    � WindowState$ 	Maximized=�6�   .��5      � ���	#FFFAFAFA � ColumnDefinitions 5    
   �� 5!      -   5         ��Name$ ColumnDefinationSideMenu��5!   +   $	��220 �6   6O   �� 5"      -   5        $ ColumnPageContainer��5"   )   $��* �6   6H    � RowDefinitions 5$   
   �� 5%      $��80 �6   6*   �� 5&      $��* �6   6)   .+�5(   
   � -   5         �Name$ GridTopMenu��5(   3   $��80��6   $	��Top=�6   ���	#FF1E282C$��2��6�   .+�5)      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   $	��250��6\   .+�5*      �� $��50��6   $��50��6$    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  60   
�������$
��10,0q�6�   ��6v   Z� ��6�   Z� .��5+      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Magnify=�6.   $��30��6=   $��30��6I   5,      �� 5-      $��50��6   $��50��6$   #��[  60   
�������$
��10,0q�6�   ��6v   Z� ��6�   Z� .��5.        $
 PlusBox=�6.   $��30��6=   $��30��6I   5/      �� 50      $��50��6   $��50��6$   #��[  60   
�������$
��10,0q�6�   ��6v   Z� ��6�   Z� .��51        $

 Bell=�6.   $��30��6:   $��30��6F   52      '  !MaterialDesignThemes.Wpf.PopupBox  53         PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  
�������$
��10,0q�6�   ��6e   Z� ��6{   Z�    PopupContent. 54      �� $	��150��6!   .+�55      �� $��Settings��6!   �� 56      $��Account��6!   �� 57      $
��Help��6!   �� 58      �� 59      -   5         ��Name$ buttonClose��59   2   $��Logout��6!   6G   5:      5;      5<      5=      � 5>   
   -   5        $ PageContainer��5>   7   $��1��6   $��1��6   $��5q�6,   .+�5?      �� $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   .��5@      �� .+�5A       � -   5          �Name$ NavigationFrame��5A      5C      5D      5E      5F      � 5L   
   -   5        $ GridMenu��5L      ���	#FF1E282C$	��220��6;   $
��Left=�6G   $��3��6�   .+�5M      �� .+�5N      � $	��Top=�6   $��80��6/   ���	#FF1E282C.+�5O      �� $K��EC:\Users\lenovo\Documents\GitHub\MonkeyCRM\Images\MonkeyCRMStyle6.png��6   $
��Left=�6k   5V      �� 5W      ���	#FF1E282C$��Disabled=�62   .@�5X      �� $��40��6#   .��5Y      �� $	 
Horizontal=�6%   .+�5Z        $

 Home=�66   $��30��6B   $��30��6N   $
��Left=�6Y   $��Center=�6t   $
��10,0q�6�   
�������6�   �� 5[      $
��Home��6(   $��Center=�64   $��Segoe UI Light)�6O   $��18(�6k   $	��5,0q�6y   
�������6�   5\      5]      �� 5^      $��40��6#   .��5_      �� $	 
Horizontal=�6%   .+�5`        $
 Timer=�66   $��30��6C   $��30��6O   $
��Left=�6Z   $��Center=�6u   $
��10,0q�6�   
�������6�   �� 5a      $��Recent��6(   $��Center=�66   $��Segoe UI Light)�6Q   $��18(�6m   $	��5,0q�6|   
�������6�   5b      5c      �� 5d      $��40��6#   .��5e      �� $	 
Horizontal=�6%   .+�5f        $	
 Pin=�66   $��30��6A   $��30��6M   $
��Left=�6X   $��Center=�6s   $
��10,0q�6�   
�������6�   �� 5g      $��Pinned��6(   $��Center=�66   $��Segoe UI Light)�6S   $��18(�6o   $	��5,0q�6}   
�������6�   5h      5i      5j      � 5k      $��Stretch=�6   $��1��65   ���	#FF1E282C.+�5l      �� $��Stretch=�6#   $��Disabled=�6A   $
��Auto=�6j   ���	#FF1E282C.��5m      �� -   5         ��Name$ MenuUserControl��5m   %   $��5q�6>   5n      5o      5p      5q      5r      5s      