   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.InfoClients   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  InfoClients��5   	   $
��1050��6   $
��1500��6+    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ CanResizeWithGrip=�6    � AllowsTransparency$
 True��5
   	   .��5      ]� ���#afb4ff.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6/   $��4 20 0 0q�6E   $	��Top=�6W   $��Right=�6o   .+�5      �� -   5        $��
Назад��5      $��42��6%   $��91��61   ���#7842E86S   5      �� 5   
   $��Center=�6   $��Center=�6.   
�������$
��1400��6\   $	��760��6i    �� CornerRadius$ 15��6v   $��0 0 0 50q�6�   ._�5      �� -   5         ��Name$ 	userList2��5      $��10,33,15,15q�6*   $��20(�6m    �� View 5      �� 5      -   5        	GridV��.P�5      �� -   5        Fios��$��Фио��5   7    �� Width$	 150��6D   	 �� DisplayMemberBinding	 6P   �� *Fio+�� 5      -   5        SerNomer��$��Серия номер��5   <   $	 200��6Q   	 6^   �� *
SreiaNomer+�� 5      -   5        Kem��$��Кем выдан��5   7   $	 180��6J   	 6V   �� *
KemVidan+�� 5      -   5        	AdresReeg��$'��!Адрес Регистрации��5   =   $	 270��6X   	 6d   �� *	AdressReg+�� 5      -   5        adreesN��$��
Адрес��5   ;   $	 200��6J   	 6V   �� *
AdresNew+�� 5      -	   5        	Telof��$��Телефон��5   9   $	 180��6J   	 6V   �� *NomerTelefon+�� 5      
 �� CellTemplate
 5      �� 5   "   .R�5   &   �� $��button��6-   -
   5        $��удалить��5   ;   ���#7842E86b   5   #   5       5!      5#      5$      5%      5&      