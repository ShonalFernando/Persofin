   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersofinDesktop.View.ProjectsPersofinDesktop.View.Projects  5      7    1PersofinDesktop.View.Projects.ProjectResourceView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:PersofinDesktop.View.Projects     5        N� Title$  ProjectResourceView��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��1* �6   �� 5      $��50 �6   .+�5   
   �� $��Project Resources��6   $��10,10,10,10q�6-   $��36(�6B   $��Segoe UI Light)�6P   $��0��6l   $
��Left=�6y   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5      �� $ 
Horizontal=�6    � ToolTip$K ECompleted Payments for completed projects for the selected date range��62   .+�5      �� $��24(�6G   $��
50,20,0,20q�6U   $	��100��6j   ��6   �� *ProjectsPaid+ �� Mode$ TwoWay=�6j   �� 5      $��/Assets/Icons/pay.png��6   $��10q�69   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5      �� $��18��6   $��10,0,0,0q�6$   ���	#3F9A9A9APayment Date6[   (  "System.Windows.Controls.DatePicker  5      $	��150��6   $��	10,5,10,5q�6}      SelectedDate 6%   �� *DateSelected+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6}   �� 5      $��	10,10,0,0q�6   ���	#3F9A9A9A---------------->6U   �� 5!      $��10,0,0,0q�6   $��30��6'   $	��120��63   $��Filter��6a      ButtonPrimary#���   6r   ��6?   �� *FilterCommand+6r   �� 5#      $��	10,10,0,0q�6   ���	#3F9A9A9A---- or ----6P   d� 5%      $��10,0,0,0q�6   $	��120��6-   $��Show All��6W     ToggleButtonPrimary#���  6j    d� 	IsChecked 69   �� *	ShowAll+6j   5&      � 5(   
   $��2��6    � ColumnDefinitions 5)      �� 5*      $��3* �6#   �� 5+      $��6* �6#   �� 5,      $��3* �6#   .+�5/      R� ��6   �� *	TreeNodes+��51      �� 52      	 �� ItemsSource	 6/   �� *
Children+.R�53      �� ��6$   �� *Title+54      56      &   System.Windows.Controls.DataGrid  58      $��1��6   
   AutoGenerateColumns$
 False��5:      ��59      �� *FilteredResources+   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+  5=      $
 Type��6)    67   �� *ResourceType+  5>      $ Added On��6)    6;   �� *	AddedOn+5@      �� 5B      $��10q�6   $��2��6%   .+�5C      �� $��Resource ID��6   $
��Left=�6/   ���	#FF3E3E3E6J   �� 5D      $ 
Horizontal=�6   .+�5E      �� $	��170��6   $
��Left=�5F      $��0,5,0,0q�5G      ��5F   /   �� *	PaymentId+{�6J   �� *IDFieldEnabled+5G      �� 5H        ButtonDashedInfo#���  6   $
��New*��5I      $��10,5,0,0q�5J      $��70��5K      $��Center=�5L      ��5M      �� *ClearEditCommand+5N      �� 5Q      $
��Name��6   $
��Left=�6(   ���	#FF3E3E3E$��0,5,0,0q�6Z   �� 5R      $	��250��6   $
��Left=�5T      $��0,5,0,0q�5U      ��5S      �� *Amount+$ TwoWay=�5U      �� 5X      $��Location (Web/Local)��6   $
��Left=�68   ���	#FF3E3E3E$��0,5,0,0q�6j   �� 5Y      $	��250��6   $
��Left=�5[      $��0,5,0,0q�5\      ��5Z      �� *Amount+$ TwoWay=�5\      �� 5^      $��Category��6   $
��Left=�6,   ���	#FF3E3E3E$��0,5,0,0q�6^   �� 5_      $	��250��6   $
��Left=�5a      $��0,5,0,0q�5b      ��5`      �� *Amount+$ TwoWay=�5b      �� 5e      $��
Collection��6   $
��Left=�6.   ���	#FF3E3E3E$��0,5,0,0q�6`   �� 5f      $	��250��6   $
��Left=�5h      $��0,5,0,0q�5i      ��5g      �� *Amount+$ TwoWay=�5i      �� 5k      $��Notes��6   $
��Left=�6)   ���	#FF3E3E3E$��0,5,0,0q�6[   �� 5l      $	��250��6   $
��Left=�5n   
   $��0,5,0,0q�5o   
    �� AcceptsReturn$
 True��5p   
    �� MinLines$ 4��5q   
   $��60��5r   
   ��5m   
   �� *Notes+$ TwoWay=�$ PropertyChanged=�5r   
   �� 5u      #���   6   $��Update Resource Data��5v   	   $��	0,25,10,0q�5w   	   $	��150��5x   	   $
��Left=�5y   	   y�5z   	   �� *IsEditButtonVisible+��5{   	   �� *UpdateCommand+�� 5}      #���   6   $��Add New Resource��5~   	   $��	0,25,10,0q�5   	   $	��150��5�   	   $
��Left=�5�   	   y�5�   	   �� *IsAddButtonVisible+��5�   	   �� *
AddCommand+5�      5�      �� 5�   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   .+�5�      �� #���   6   $��← Back to Project��6=   $	��135��6Y   ��6e   �� *GotoAddProjectCommand+�� 5�      #���   6   $��Edit Resource Data��6=   $	��135��6Z   $��10,0,0,0q�6f   ��6x   �� *GoToEditCommand+�� 5�        ButtonDanger#���  6   $��Delete Resource Data��6<   $	��135��6[   $��10,0,0,0q�6g   ��6z   �� *DeleteCommand+5�      5�      5�      