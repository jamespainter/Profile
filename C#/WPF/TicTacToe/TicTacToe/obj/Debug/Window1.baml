   M S B A M L   `   `   `  ����  	TicTacToe    TicTacToe.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  Total Players��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�6>   ���	#FFD50D0D���	#FF532B72.��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ lblQuestion��5      $��1��6%   $��	Question:��65   ���	#FFFDF8F8$��1,0,-1.4,0.2q�6`   	� 5   
   -   5         	�Name$ rbtn_one��5       	� 	GroupName$ players��6(   $��1��6<   $��1��6L   $��	70,30,0,0q�6X   ���	#FFF7EDED6k   	� 5   
   -   5        $ rbtn_two��5      $ players��6(   $��4��6<   $��2��6L    d� 	IsChecked$
 TrueY�6X   $��110,30,0,18q�6i   ���	#FFFCF7F76~   � 5   
   $��2��6   $��2��6!   $��Right=�65   $��0,15,0,0q�6Q   .+�5      �� -   5        	 ��Name$	 btnDialogOk��5   &   
 �� 	IsDefault
 . $��60��6U   $��0,0,10,0q�6c   $	��_Ok��6u   �� 5       �� IsCancel . $��60��6%   $��_Cancel��63   5      5      5      