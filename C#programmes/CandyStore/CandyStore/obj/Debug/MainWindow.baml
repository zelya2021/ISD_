   M S B A M L   `   `   `  ����E  ACandyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CandyStore
CandyStore  5   	       CandyStore.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $localclr-namespace:CandyStore  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1024��6)    � WindowStartupLocation$ CenterOwner=�66    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p   .��5      � 
�������.+�5   
   �  � RowDefinitions 5      �� 5      $	��49* �6    .+�5      �� ���	#FF3E474F$��	0,0,0,567q�6/   �� 5      -   5         ��Name$ ButtonFechar��5      $
��Auto��6+   $��0q�6f   
�������$��948,5,-24,567q�6�   ��69   Z� ��6O   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Power=�6*   $��28��67   $��41��6C   5      5      � 5   
   -   5        $��MainGrid��5   K   $��357,55,0,25q�6   $
��Left=�6$   $	��642��6?   .+�5      � -   5         �Name$ GridProncipal��5      $��Center=�6*   $��Center=�6G   5      � 5   
   $	��334��6   $
��Left=�6   ���	#FF3E474F.+�5      �� .+�5      �� $��Candy��6    �� Padding$ 0q�6)   $��44,0,153.4,30q�65   $��57��6L   $��40(�6X   $��Center=�6f   $��Center=�6�   $��Segoe Script)�6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF9D9DAB��6�   Z� 6�   �� 5      $��Store��6   $ 0q�6)   $��86,-40,52.4,30q�65   $��58��6M   $��40(�6Y   $��Segoe Script)�6g   $
��Bold"�6�   $��Italic$�6�   ���	#FF9D9DAB6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      -   5        $��TrainsitionigContentSlide��5   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6S   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X�.��5       � -   5        $��
CridCursor��5       ���	#FF262432$��	0 160 0 0q�6@   $��10��6S   $
��Left=�6^   $��60��6y   $	��Top=�6�   5!      �� 5#      -   5         ��Name$ ListViewMenu��5#   +   $��0q�6   $��10,160,0,10q�6A   
����������	#FF3E474F.@�5$      �� $��60��6   
�������.��5%      � .+�5'        $
 Home=�62   $��30��6>   $��30��6J   $��Center=�5(      $��5q�64   �� 5)      $��Каталог��6$   $��24(�63   $��Center=�6A   $
��45 0q�6\   $��Frank Ruehl CLM)�6j   $
��Bold"�6�   5*      5+      �� 5-      $��60��6   
�������.��5.      � .+�5/        $ FoodForkDrink=�62   $��30��6H   $��30��6T   $��Center=�50      $��5q�64   �� 51      $��Все десерты��6$   $��24(�67   $��Center=�6E   $
��45 0q�6`   $��Frank Ruehl CLM)�6n   $
��Bold"�6�   52      53      54      58      59      5:      