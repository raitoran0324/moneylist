   M S B A M L   `   `   `  ����C  ?todolist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:todolisttodolist  5   	       todolist.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:todolist     5   	   -   5          � Title$  
MainWindow��5   	   $	��550��6   $	��375��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��70 �6   6*   .+�5   
   �� $��0��6   $
��Auto=�6$   .��5      �� -   5         ��Name$ TodoItemList��5      61   5      �� 5   
   $��1��6   
�����F�
������ 6I      todolist.AddMark  5   
      todolist.AddMark   	MouseDown$ AddMark_MouseDown��6;   $��1��6   $��20 10 295 10q�6%   6[   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��
250 5 20 5q�69   .+�5      �� -   5         ��Name$ 	Totalword��5   &   $��15(�6   
�������$��Right=�6L   	總支出6m   �� 5      -   5        $ Total��5   &   $��30(�6   
�������$
��Bold"�6H   $��77,0,0,0q�6Z   06�   5      5      5      