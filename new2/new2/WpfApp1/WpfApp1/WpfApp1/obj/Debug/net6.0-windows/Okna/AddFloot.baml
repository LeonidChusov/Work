   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.AddFloot   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$
  User��5
   	   $	��260��6   $	��500��6"   ���#afb4ff.��5      ]�  � DataContext 6   ��  �� Mode$ OneWay=� �� RelativeSource ��  �� Mode$
 Self=�.+�5   
   �� $��4 0 0 0q�6    �� Orientation$ Vertical=�6&   $	��Top=�6=   $	��200��6R   $��Center=�6^   $
��Left=�6y   .+�5      �� $#��Добавить объект��6   $��Center=�6.   $��18(�6P   $
��Bold"�6^   �� 5      $��11��6   �� 5      -   5        $	��109��5      ���#7842E8
�������$
��Left=�6I   $��Center=�6d   $��Сохранить��6   6�   �� 5      �� 5      -   5        $��81��5      ���#7842E8
�������$
��Left=�6H   $��
Назад��6c   6s   5      �� 5   
   
�������$	��210��6$   $	��300��60   $
��Left=�6=   $��Center=�6X   $��10q�6s    �� CornerRadius$ 15��6   ._�5      �� .@�5      �� -   5         ��Name$ imagText��5      $	��170��6,   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Изоброжение��68   �� 5      -   5        $ priceimagText��5      $	��170��61   $ Цену��6=   �� 5      -   5        $ komnimagText��5      $	��170��61   $ Кол-во комнат��6=   �� 5      -   5        $ metreimagText��5      $	��170��61   $ 
Метры��6=   �� 5      -   5        $ itaggimagText��5      $	��170��61   $ Этаж��6=   �� 5      -   5        $ adresimagText��5      $	��170��61   $ 
Адрес��6=   �� 5      -	   5        $ 	microText��5      $	��170��6-   $ 
Район��69   �� 5      -
   5        $ 
remontText��5      $	��170��6.   $ Ремонт��6:   �� 5      -   5        $ 
srokVlText��5      $	��170��6.   $ Срок владения��6:   �� 5       -   5        $ opisText��5       $	��170��6,   $ Описание��68   5!      5"      5$      5%      