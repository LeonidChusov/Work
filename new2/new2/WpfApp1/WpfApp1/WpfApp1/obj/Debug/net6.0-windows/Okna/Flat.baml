   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Flat   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$
  Flat��5	   	   $
��1150��6   $
��1800��6$    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ CanResizeWithGrip=�6    � AllowsTransparency$
 True��5   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 ��Name ��Name J� Opacity
 � Tag ��Name ��Name �� Triggers :� RoutedEvent �� TargetProperty g� AutoReverse W� From	 W� To g� Duration W� EasingFunction.  (System.Windows.Media.Animation.CubicEase P� Property P� Value �� 
TargetName �� ElementName �� Path��%~  '��       '�� �     �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $	 10��6!   #��z��5   !   ._�5      �� #��z��6/   #��z��5   /   5      5      5      5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5       �� $
 border��6!   $	 5��61   #��z��6B   #��z��6l   ._�5!      � $
��10,0q�6#   .+�5"   "   �� $ 	watermark��6,   $��Center=�6?   $y�	Collapsed=�6Z   #��z��6q   $	 0.4Q�6�   #��z 6�   6�   �� 5#   "   $ PART_ContentHost��6/   $��Center=�6I   6f   �� 5$   "   $
 rect��6,   
������ $��2��6M   $��Bottom=�6X   $��Stretch=�6s   $	��0,3q�6�   6�   5%      5&       5'      :� 5(      $ GotFocus��6+   .[�5)   "   �� .��5*   &   �� .��5+   *   W� $ Width�6:   $
 True��6\    2506o    2556z   $ 0:0:0.15D�6�    5,   .     5-   2   6?   5/   +   W� 50   *   $ Height�6:   $
 True��6]    406p    456z   $ 0:0:0.15D�6�    51   .     52   2   6?   54   +   55   '   56   #   57      P� 58       �@J�	IsFocused$
 true��6;   . �59   "   �� $
 rect��6)    6K   �� $ border��$ BorderBrush� � ��6�   5:      P� 5;       � ��$  ��66   . �5<   "   �� $ 	watermark��6)    � y�$ Visible=�6V   6h   5=      5?      5A      5B      5C      .��5E      ]� ���#afb4ff � DataContext 6   ��  �� Mode$ OneWay=� �� RelativeSource ��   �� Mode$
  Self=�.+�5G   
   �� ! �� Orientation$! 
Horizontal=�6   $	��Top=�6/   $��4 20 0 0q�6E   $	��Top=�6W   $��Center=�6o   .+�5H      �� �� 5I      -   5        " ��Name$" 
poiskPrice��5I      $	��247��6*   $ Поиск по цене��66   $��24(�6J   
�������.��6�   5J      �� 5K      �� 5L      -   5        $" poiskKvadrantmetr��5L      $	��247��61   $ Площадь��6=   )  #MaterialDesignThemes.Wpf.HintAssist#   Hint$# Площадь��6K   $��24(�6t   
�������6�   �� 5M      �� 5N      -   5        $" 
poiskFloot��5N      $	��247��6*   $' !Количество комнат��66   $'# !Количество комнат��6N   $��24(�6�   
�������6�   �� 5O      �� 5P      -   5        $" 	poiskAtag��5P      $	��247��6)   $ Этаж��65   $# Этаж��6@   $��24(�6f   
�������6�   �� 5Q      �� 5R      -   5        $	��112��5R      ���#7842E8$��
Назад��66   ���#F5F5F5$��24(�6p   $��39��6~   �� 5S      �� 5T      -   5        $	��122��5T      ���#7842E8$��Удалить��66   ���#F5F5F5$��24(�6t   $��39��6�   �� 5U      �� 5V      -   5        $	��150��5V      ���#7842E8$��Добавить��66   ���#F5F5F5$��24(�6u   $��39��6�   �� 5W      5X      �� 5Z   
   $
��1600��6   $	��800��6   
�������$��Center=�6>   $��Center=�6[   $	 15��6v   $ J� Effect$ 5[      3  -System.Windows.Media.Effects.DropShadowEffect  5\      %   
BlurRadius$% 30Q�6#   &   Color$& #800080��63   '   ShadowDepth$' 0Q�6C   ._�5_      �� -   5        ( ��Name$( userList��5_      $��	0,33,0,15q�6)   $��20(�6i   $��Center=�6w   
�������$
��1265��6�   ) �� View) 5`      �� 5a      -	   5        	GridV��.P�5b      �� $��Изображение��6)   * �� Width$	* 320��6>   + �� CellTemplate+ 5c      �� 5d   "   .R�5e   &   �� $	��200��6F   $	��200��6R   ��6,   �� *Imagge+6R   5f   #   5h      �� 5i      -
   5        	priceRoom��$��Цена��5i   <   $	* 200��6J   , �� DisplayMemberBinding, 6V   �� *Price+- �� StringFormat$- {0:0} рублей���� 5j      -   5        
komnat��$'��!Количество комнат��5j   :   $	* 150��6U   , 6b   �� *
FlootKom+�� 5k      -   5        m��$
��м²��5k   5   $	* 100��6A   , 6M   �� *Metr+$- 	{0:0}м²���� 5l      -   5        itaj��$��Этаж��5l   8   $	* 140��6F   , 6R   �� *Ittag+�� 5m      -   5        
adreesRoom��$��
Адрес��5m   >   $	* 200��6M   , 6Y   �� *	Adreess+�� 5n      $	* 147��6)   + 5o      �� 5p   "   .R�5q   &   �� $��button2��6-   -   5        $��посмотреть��5q   <   $	��120��6g   ���#7842E8���#F5F5F56�   5r   #   5t      5u      5w      5x      5y      5z      