   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Prosmotr   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$  Prosmotr��5	   	   $	��950��6   $
��1400��6'    � WindowStyle$
 None=�65    � 
ResizeMode$ CanResizeWithGrip=�6H    � AllowsTransparency$
 True��6g   ���#afb4ff.��5      ]�  � DataContext 6   ��  �� Mode$ OneWay=� �� RelativeSource ��  �� Mode$
 Self=�.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6/   $��4 20 0 0q�6E   $	��Top=�6W   $��Center=�6o   .+�5      �� -   5        $	��150��5      ���#7842E8$��Печать��66   
�������$��24(�6q   $��39��6   �� 5      6   �� 5      -   5        $	��150��5      ���#7842E8$��
Назад��66   
�������$��24(�6n   $��39��6|   5      �� 5   
   
�������$
��1300��6$   $	��900��61   $��Center=�6>   $��Center=�6[   	 �� CornerRadius$	 20��6v   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$	 100Q�6#      Color$ #800080��64      ShadowDepth$ 1Q�6D   ._�5      �� -   5        $
��Live��5   $   $��1��6   $��Center=�60   $��Center=�6M   ��5      �� 5      .R�5      � $��30q�6   $
��auto��6+   $��Center=�68   $��Center=�6U    � RowDefinitions 5      �� 5   "   $	��580 �60   6?   �� 5   "   $
��auto �60   6@   �� 5   "   $
��auto �60   6@   �� 5   "   $
��auto �60   6@   �� 5    "   $
��auto �60   6@   �� 5!   "   $
��auto �60   6@   �� 5"   "   $
��auto �60   6@   �� 5#   "   $
��auto �60   6@   �� 5$   "   $
��auto �60   6@   �� 5%   "   $
��auto �60   6@   .+�5'      �� $	��500��6>   $	��500��6J   $��Center=�6W   $��Center=�6t   $��0 0 0 0q�6�   ��6$   �� *Imagge+6�   �� 5(      $	��Top=�6]    �� TextAlignment$ Center=�6u   $	��350��6�   $
��Wrap=�5)      $��Center=�60   $	��5 5q�6M   $��26(�6Z   $��0��6h   ��5(   (   �� *	Adreess+ �� StringFormat$ {0} - Адрес��5)   h   �� 5*      $��2��6\   $��5 5 5 15q�6i   $��26(�6{   $��Center=�6�   $
��Bold"�6�   ��6(   �� *Price+$ {0:0} рублей��6�   �� 5+      $��3��6f   $��14(�6s   $��Right=�6�   ��6(   �� *Metr+$- '{0} - Квадратных метров��6�   �� 5,      $��3��6[   $��14(�6h   $
��Left=�6w   ��6(   �� *Ittag+$ {0} - Этаж��6w   �� 5-      $��3��6j   $��Center=�6w   $��16(�6�   $ Center=�6�   $	��390��6�   $��0 0 50 0q�6�   ��6(   �� *
FlootKom+$- '{0} - Количество комнат��6�   �� 5.      $��4��6`   $��Center=�6m   $��16(�6�   $ Center=�6�   $	��390��6�   $��0 0 50 0q�6�   ��6(   �� *
MictoRoiin+$ {0} - район��6�   �� 5/      $��5��6]   $��Center=�6j   $��16(�6�   $ Center=�6�   $	��390��6�   $��0 0 50 0q�6�   ��6(   �� *Remont+$ {0} - ремонт��6�   �� 50      $��6��6j   $��Center=�6w   $��16(�6�   $ Center=�6�   $	��390��6�   $��0 0 50 0q�6�   ��6(   �� *SrokVladenia+$% {0} - срок владения��6�   �� 51      $��7��6c   $��Center=�6p   $��16(�6�   $ Right=�6�   $	��890��6�   $��0 0 50 0q�6�   ��6(   �� *
Opisaninie+$ {0} - описание��6�   �� 52      -   5        $��8��52   %   $��	0 20 50 0q�62   ���#7842E8$��
Карта��6Z   6�   53      54      56      57      58      59      