   M S B A M L   `   `   `  ����U  QUniver_Project_Worker_Side, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Univer_Project_Worker_SideUniver_Project_Worker_Side  5   	   .    (Univer_Project_Worker_Side.WindGetReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Univer_Project_Worker_Side     5   	     � Title$#  Запросить отчет��5   	   $��506.25��6!   $��733.594��61    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ NoResize=�6f   ��5	      �� 5
   
    �� ImageSource$ Data/Graphics/back.png��6   .��5      �� .+�5   
   �� $%��Генерация отчета��6   $��40(�6+   $��Center=�69   
�������$��Shonar Bangla)�6i   5      �� 5   
   $)��#Выберите критерий: ��6   $��25(�6.   $��Center=�6<   
�������$��Shonar Bangla)�6l   5      �� 5   
   -   5        $��cb��5      $��Center=�6   $��Center=�6:   $��16(�6U   .@�5      �� $8��2Дата регистрации заявления��6   �� 5      $e��_Дата информирования об изготовлении акцизных марок��6   �� 5      $:��4Дата принятия обязательства��6   �� 5      $6��0Дата принятия обеспечения��6   �� 5      $0��*График получения марок��6   �� 5      $,��&Дата получения марок��6   �� 5      $,��&Дата закрытия отчета��6   5      �� 5   
   $U��OВыберите временной промежуток (ДД.ММ.ГГГГ): ��6   $��25(�6G   $��Center=�6U   
�������$��Shonar Bangla)�6�   5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5       �� $
��От��6   $	��350��6!   $��Center=�6-   $��Center=�6Q   
�������$��25(�6   5"      �� 5#      $
��До��6   $	��350��6!   $��Center=�6-   $��Center=�6Q   
�������$��25(�6   5%      5&      �� 5'   
   $ 
Horizontal=�6   .+�5(      (  "System.Windows.Controls.DatePicker  -   5        $	��dp1��5(      $��Center=�6$   $	��365��6H   6V     5)      -   5        $	��dp2��5)      $��Center=�6$   $	��353��6H   5*      �� 5+   
   -   5        $��btnGetReport��5+      $��Подтвердить��6%   $��65q�6;    � Cursor$
 Hand��6G   $��Center=�6U   $��Center=�6r   $��Shonar Bangla)�6�   $��16(�6�   
���   ���5,      �� 5-       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5.      �  � Color$ 	#FFF3F3F3��6#   	 � Offset$	 0Q�65   � 5/      $ 	#FFEBEBEB��6#   $		 0.5Q�65   � 50      $ 	#FFDDDDDD��6#   $		 0.5Q�65   � 51      $ 	#00FDFDFD��6#   $	 1Q�65   52      54      �� 55   
   -   5        $��	lblStatus��55      $��Center=�6!   $��Center=�6E   
�������$��25(�6s   57      58      59      