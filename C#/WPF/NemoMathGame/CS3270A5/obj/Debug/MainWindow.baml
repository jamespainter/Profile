   M S B A M L   `   `   `  ����C  ?CS3270A5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CS3270A5CS3270A5  5   	       CS3270A5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CS3270A5     5   	   -   5          �Name$  wnd_main��5   	    � Title$ 
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      � .+�5   
   �� -   5         ��Name$ img_nemoStartPage��5      $��-1,8,-3,-1.2q�6+   $��nemoStartPage.jpg��6A   $
��Fill=�6\   �� 5   
   -   5        $ img_ActualNemo��5      $��Nemo-FN.png��6(   $��-102,123,213,-23.2q�6=   z�5      �� 5      -   5        AnimatedRotateTransform�� �� Angle$ 0Q�5   C    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ AnimatedRotateTransform��6.    �� TargetProperty$ Angle�5   2   	 W� By$ 45X�5   2   		 W� To$		 225X�5   2   
 g� Duration$
 0:0:4D�5   2    g� FillBehavior$
 Stop=�5   2   5      5      5      5      ]� 5   
   $
��Left=�6   $	��346��6/   ��.  $��-2,-21,0,-2.2q�6R   $	��Top=�6i   $	��522��6�   ]� 5!   
   -   5         ]�Name$ menu_options��5!      $��-2,-1,2,0.8q�6*   .+�5"      o� $	��Top=�6   ���	#FF3F3B3B���	#FFFAF9F9$��0,0,-2,0q�6V   .@�5#      m� $��_Options��6   ���	#FFFAF9F9.@�5$      m� -   5        $��_Edit/Enter User Info��5$      ���	#FF0E0E0E6U   m� 5%      -   5        $��
_Play Game��5%      ���	#FF1211116J   m� 5&      -   5        $��_Exit��5&      ���	#FF0F0F0F6E   5'      5(      �� 5)      5*      �� 5+   
   -	   5        $ 	Shark_png��5+      $��271,190,-38,-28.2q�6#   $��	Shark.png��6>   $
��Fill=�6Q   �� 5,   
   -
   5         ��Name$ btn_edit_user_info��5,      $��Add User Info.��6-   $
��Left=�6F   $��59��6a   $��203,228,0,0q�6m   $	��Top=�6�   $	��144��6�   ���	#FFDB8E6C���	#FFF26E4D���	#FF1E46B0$��Snap ITC)�6�   $��3q�6  $��16(�6  $y�Hidden=�6E  �� 5-   
   -   5         ��Name$ textBox��5-      $
��Left=�6#   $��26��6>   $��254,291,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $��83��6�   $y�Hidden=�6�   �� 5.   
   -   5        $ btn_start_game��5.      $��	Play Game��6)   $
��Left=�6=   $��57��6X   $��200,154,0,0q�6d   $	��Top=�6y   $	��148��6�   ���	#FFDB8E6C���	#FFF26E4D���	#FF1E46B0$��Snap ITC)�6�   $��16(�6�   $��3q�6  $y�Hidden=�68  5/      51      