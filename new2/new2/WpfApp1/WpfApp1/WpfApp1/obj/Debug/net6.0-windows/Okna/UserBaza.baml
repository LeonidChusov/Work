   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.UserBaza   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$
  User��5
   	   $	��500��6   $	��500��6"    � WindowStyle$
 None=�6/    � 
ResizeMode$ CanResizeWithGrip=�6B    � AllowsTransparency$
 True��6a   ���#afb4ff.��5      ]�  � DataContext 6   ��  �� Mode$ OneWay=� �� RelativeSource ��  �� Mode$
 Self=�.+�5   
   �� $��4 0 0 0q�6    �� Orientation$ Vertical=�6&   $	��Top=�6=   $��Center=�6R   $��Center=�6m   .+�5      �� 
�������$	��200��6(   $��50��64   $��Center=�6@   $��Center=�6]   $��10q�6x   	 �� CornerRadius$	 15��6�   ._�5      �� $)��#Добовление клиента��6   $��Center=�65   $��18(�6W   $
��Bold"�6e   5      �� 5      $��81��6   �� 5      -   5        $	��109��5      ���#7842E8$��Сохранить��66   
�������6]   �� 5      �� 5      -   5        $��81��5      ���#7842E8$��
Назад��65   
�������6X   5      �� 5   
   
�������$	��210��6$   $	��312��60   $	 15��6=   ._�5      �� .@�5      �� -   5        
 ��Name$
 fioText��5      $	��170��6+   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ФИО��67   �� 5      -   5        $
 datarogdText��5      $	��170��60   $ Дата рождения��6<   �� 5      -   5        $
 	seriaText��5      $	��170��6-   $/ )серия и номер паспорта��69   �� 5      -   5        $
 kemvidanText��5      $	��170��60   $ Кем выдан��6<   �� 5      -   5        $
 adresregText��5      $	��170��60   $' !Адрес регистрации��6<   �� 5      -   5        $
 adresnewText��5      $	��170��60   $/ )Адрес на данный момент��6<   �� 5      -	   5        $
 telefonText��5      $	��170��6/   $! Номер телефона��6;   5      5       5!      5"      