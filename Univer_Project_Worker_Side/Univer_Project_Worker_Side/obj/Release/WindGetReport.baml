   M S B A M L   `   `   `  ���� U  QUniver_Project_Worker_Side, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Univer_Project_Worker_SideUniver_Project_Worker_Side  .    (Univer_Project_Worker_Side.WindGetReport   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:Univer_Project_Worker_Side       � Title$#  Запросить отчет��$��506.25��$��733.594�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�����  �� ImageSource$ Data/Graphics/back.png��.���� .+��� $%��Генерация отчета��$��40(�$��Center=�
�������$��Shonar Bangla)��� $)��#Выберите критерий: ��$��25(�$��Center=�
�������$��Shonar Bangla)��� -   $��cb��$��Center=�$��Center=�$��16(�.@��� $8��2Дата регистрации заявления���� $e��_Дата информирования об изготовлении акцизных марок���� $:��4Дата принятия обязательства���� $6��0Дата принятия обеспечения���� $0��*График получения марок���� $,��&Дата получения марок���� $,��&Дата закрытия отчета���� $U��OВыберите временной промежуток (ДД.ММ.ГГГГ): ��$��25(�$��Center=�
�������$��Shonar Bangla)���  �� Orientation$ 
Horizontal=�.+��� $
��От��$	��350��$��Center=�$��Center=�
�������$��25(��� $
��До��$	��350��$��Center=�$��Center=�
�������$��25(��� $ 
Horizontal=�.+�(  "System.Windows.Controls.DatePicker  -   $	��dp1��$��Center=�$	��365��  -   $	��dp2��$��Center=�$	��353���� -   $��btnGetReport��$��Подтвердить��$��65q� � Cursor$
 Hand��$��Center=�$��Center=�$��Shonar Bangla)�$��16(�
���   �����  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ 	#FFF3F3F3��	 � Offset$	 0Q�� $ 	#FFEBEBEB��$		 0.5Q�� $ 	#FFDDDDDD��$		 0.5Q�� $ 	#00FDFDFD��$	 1Q��� -   $��	lblStatus��$��Center=�$��Center=�
�������$��25(�