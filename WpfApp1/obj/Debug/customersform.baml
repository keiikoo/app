   M S B A M L   `   `   `  ����=  9а, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.customersform   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  customersform��5   	   $��900         ��6   $
��1440��5	      ���	#FFFFF5DD$��Montserrat Medium)�6/    � 	Resources 5
       
  data_1 �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  chs1 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   &	        &	 ]     �� 5   
   "  6   .�5      ��  �@ ColumnHeaderStyle# �  62   6S   5      �� 5   
   "  6   .�5      ��  � �� �#69513D6=   5      5      .��5      � .+�5   
   �� $��ЗАКАЗЧИКИ��6   $��118,106,0,0q�6$   $��
Montserrat)�69   $��52(�6Q   $
��Bold"�6_   ���	#FF917055$
��Left=�6�   $	��Top=�6�   $	��432��6�   6�   �� 5   
   $ ��Код заказчика:��6   ���	#FF917055$��Montserrat Medium)�6@   $��18(�6_   $��118,208,0,0q�6m   $
��Left=�6�   $	��Top=�6�   $	��207��6�   $��61��6�   6�   �� 5   
   -   5        $��CustomerCode��5      $
��Left=�6&   $��118,243,0,0q�6A   $	��Top=�6V   $	��432��6n   $��52��6z   ���	#FF917055���	#FFFFF5DD$��Montserrat Medium)�6�   $��20(�6�   $��15, 12q�6�   .��6�    5      ��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 25��65   5      5      .��6!   5      �� 5   
   -   5        $��Search��5      $��
ПОИСК��6    $��0q�60   $
��Left=�6D   $��118,322,0,0q�6_   $	��Top=�6t   $��88��6�   $	��303��6�   $��
Montserrat)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF917055���	#FFFFF5DD 5      ��%_   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 15��65   5!      5"      5#        5$   
   -   5        $��CustomersInfo��5$   v      HeadersVisibility$ Column=�6      ColumnHeaderHeight$ 50Q�6.      	RowHeight$ 30Q�6F   #���   6U   $��609,106,90,148q�6�   $��14(�6�   $��Montserrat Medium)�6�      VerticalGridLinesBrush �#69513D	   HorizontalGridLinesBrush	 �#69513D
   RowBackground
 �	#FF917055   AlternatingRowBackground �#C19676   AutoGenerateColumns . ���	#FF917055���	#FFFFF5DD6�  �� 5%   
   -   5        $
��Show��5%      $��ПОКАЗАТЬ��6   $��0q�61   $
��Left=�6E   $��118,568,0,0q�6`   $	��Top=�6u   $��88��6�   $	��303��6�   $��
Montserrat)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF917055���	#FFFFF5DD 5&      ��%_   '��       �� 5'      " ��6   .�5(      ��  �@��CornerRadius$ 15��65   5)      5*      5+      �� 5,   
   -   5        $��Delete��5,      $��УДАЛИТЬ��6    $��0q�62   $
��Left=�6F   $��118,442,0,0q�6a   $	��Top=�6v   $��88��6�   $	��303��6�   $��
Montserrat)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF917055���	#FFFFF5DD 5-      ��%_   '��       �� 5.      " ��6   .�5/      ��  �@��CornerRadius$ 15��65   50      51      52      53      54      