   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Kalkulator   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$  
Kalkulator��5	   	   $	��450��6   $	��500��6)    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius ��Name	 J� Opacity

 � Tag ��Name ��Name �� Triggers :� RoutedEvent �� TargetProperty g� AutoReverse W� From	 W� To g� Duration W� EasingFunction.  (System.Windows.Media.Animation.CubicEase P� Property P� Value �� 
TargetName �� ElementName �� Path��%�  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 5��61   #��z��6B   #��z��6l   ._�5      � $
��10,0q�6#   .+�5   "   �� $ 	watermark��6,   $��Center=�6?   $y�	Collapsed=�6Z   #��z��6q   $		 0.4Q�6�   #��z
 6�   6�   �� 5   "   $ PART_ContentHost��6/   $��Center=�6I   6f   �� 5   "   $
 rect��6,   
������ $��2��6M   $��Bottom=�6X   $��Stretch=�6s   $	��0,3q�6�   6�   5      5       5      :� 5      $ GotFocus��6+   .[�5   "   �� .��5   &   �� .��5   *   W� $ Width�6:   $
 True��6\    2506o    2556z   $ 0:0:0.15D�6�    5   .     5   2   6?   5   +   W� 5    *   $ Height�6:   $
 True��6]    406p    456z   $ 0:0:0.15D�6�    5!   .     5"   2   6?   5$   +   5%   '   5&   #   5'      P� 5(       �@J�	IsFocused$
 true��6;   . �5)   "   �� $
 rect��6)    6K   �� $ border��$ BorderBrush� � ��6�   5*      P� 5+       � ��$  ��66   . �5,   "   �� $ 	watermark��6)    � y�$ Visible=�6V   6h   5-      5/      51      52      53      .��55      � ���#afb4ff.+�56   
   �� -   5         ��Name$	 sum��56      $
��Left=�6   $��
10,119,0,0q�6:    �� TextWrapping$
 Wrap=�6N   $
 Сумма (руб.)��6b   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Сумма (руб.)��6u   $	��Top=�6�   $	��120��6�   $��20��6�   �� 57   
   -   5        $ sroki��57      $��Center=�6!   $��	0,119,0,0q�6>   $
 Wrap=�6Q   $
 Срок (лет)��6e   $ Срок (лет)��6v   $	��Top=�6�   $	��120��6�   $��20��6�   �� 58   
   -   5        $ stavkaki��58      $
��Left=�6$   $��370,119,0,0q�6?   $
 Wrap=�6T   $
 Ставка (%)��6h   $ Ставка (%)��6y   $	��Top=�6�   $	��120��6�   $��20��6�   �� 59   
   -   5        $��Рассчитать��59      ���#7842E8$��Center=�6;   $��Center=�6X   6s   �� 5:   
   -   5        $ platatka��5:      $��Center=�6$   $��	0,285,0,0q�6A   $
 Wrap=�6T   $
 Плата (руб .)��6h   $ Плата (руб .)��6|   $	��Top=�6�   $	��120��6�   $��20��6�   �� 5;   
   -   5        $��
Назад��5;      $
��Left=�6!   ���#7842E8$��370,356,0,0q�6Q   $	��Top=�6f   $��91��6�   �� 5<   
   $/��)Ипотечный калькулятор��6   $��26(�60   $��Center=�6>   $��0,35,0,0q�6[   $	��Top=�6m   5=      5>      