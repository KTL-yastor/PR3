   M S B A M L   `   `   `  ����B  >asyncpr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:asyncprasyncpr  5   	       asyncpr.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:asyncpr     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $	��.2* �6   �� 5      $��10 �6   �� 5      �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ tb_first��5      $��2��6&   $��20(�66   $
��Wrap=�6D   $��	TextBlock��6X   $��0��6i   �� 5   
   -   5         ��Name$ Label_pierwszy��5      $��25(�6   $��2��66   $��Test label text��6F   $��Center=�6`   $��Center=�6~   �� 5   
   -   5         ��Name$ 	bnt_first��5      $��2��6$   $��Pracuj i Uaktualnij��64   $��Stretch=�6S   $��Stretch=�6r   $��1��6�   6�   �� 5    
   -   5        $ 
bnt_second��5       $��2��6%   $(��"Pracuj i Uaktualnij w nowym wątku��65   $��2��6b   $��Stretch=�6o   $��Stretch=�6�   6�   �� 5!   
   -   5        $ 	bnt_third��5!      $��2��6$   $	��box��64   $��3��6C   $��Stretch=�6Q   $��Stretch=�6p   6�   �� 5"   
   -   5        $ bnt_four��5"      $��2��6#   $��Button��63   $��4��6E   $��Stretch=�6S   $��Stretch=�6r   6�   �� 5#   
   -   5        $ bnt_five��5#      $��2��6#   $)��#Pracuje i uaktualnia i nie zawiesza��63   $��5��6b   $��Stretch=�6p   $��Stretch=�6�   6�   �� 5$   
   -   5        $ bnt_awaitTylkoDlaOperacji��5$      $��2��64   $��Await dla operacji��6D   $��6��6b   $��Stretch=�6p   $��Stretch=�6�   6�   �� 5%   
   -	   5        $ bnt_asyncAwait1��5%      $��2��6*   $��Async + await1��6:   $��7��6T   $��Stretch=�6b   $��Stretch=�6�   6�   �� 5&   
   -
   5        $ 	bnt_eight��5&      $��2��6$   $��Button��64   $��8��6F   $��Stretch=�6T   $��Stretch=�6s   6�   �� 5'   
   $��2��6   $��CheckBox��6#   $��9��67   $��Center=�6D   $��Center=�6_   �� 5(   
   $��0��6   $��/pic/test.jpg��6    $��10��69   $��UniformToFill=�6K    � Cursor$ ArrowCD��6c   �� 5)   
   
���   �$��10��6!   $��4��6/   5*      5+      