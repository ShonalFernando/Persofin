   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersofinDesktop.View.ProjectsPersofinDesktop.View.Projects  5      0    *PersofinDesktop.View.Projects.PaymentsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:PersofinDesktop.View.Projects     5        N� Title$  ProjectsView��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��1* �6   �� 5      $��50 �6   .+�5   
   �� $��Project Payments��6   $��10,10,10,10q�6,   $��36(�6A   $��Segoe UI Light)�6O   $��0��6k   $
��Left=�6x   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5      �� $ 
Horizontal=�6    � ToolTip$K ECompleted Payments for completed projects for the selected date range��62   .+�5      �� $��24(�6G   $��
50,20,0,20q�6U   $	��100��6j   ��6   �� *ProjectsPaid+ �� Mode$ TwoWay=�6j   �� 5      $��/Assets/Icons/pay.png��6   $��10q�69   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5      �� $��18��6   $��10,0,0,0q�6$   ���	#3F9A9A9APayment Date6[   (  "System.Windows.Controls.DatePicker  5      $	��150��6   $��	10,5,10,5q�6}      SelectedDate 6%   �� *DateSelected+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6}   �� 5      $��	10,10,0,0q�6   ���	#3F9A9A9A---------------->6U   �� 5!      $��10,0,0,0q�6   $��30��6'   $	��120��63   $��Filter��6a      ButtonPrimary#���   6r   ��6?   �� *FilterCommand+6r   �� 5#      $��	10,10,0,0q�6   ���	#3F9A9A9A---- or ----6P   d� 5%      $��10,0,0,0q�6   $	��120��6-   $��Show All��6W     ToggleButtonPrimary#���  6j    d� 	IsChecked 69   �� *	ShowAll+6j   5&      � 5(   
   $��2��6    � ColumnDefinitions 5)      �� 5*      $	��11* �6#   �� 5+      $��3* �6#   .+�5-      &   System.Windows.Controls.DataGrid  	   AutoGenerateColumns$	 False��5/      
   SelectionMode$
 Single=�50         
IsReadOnly$
 True��51      ��5-      �� *
Payments+ �� SelectedItem 5.      �� *SelectedPayment+$ TwoWay=�   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	PaymentId+6W     57      $ Amount��6-   $ * 6s    6=   �� *Amount+ �� StringFormat$ 
{0:N2} LKR��6s     58      $ Payment Date��6-   $ * 6c    6C   �� *PaymentDate+6c     59      $ Notes��6-   $ * 6V    6<   �� *Notes+6V   5<      �� 5?      $��10q�6   $��1��6%   .+�5@      �� $��
Payment ID��6   $
��Left=�6.   ���	#FF3E3E3E6I   �� 5A      $ 
Horizontal=�6   .+�5B      �� $	��170��6   $
��Left=�5C      $��0,5,0,0q�5D      ��5C   3   �� *	PaymentId+{�6N   �� *IDFieldEnabled+5D      �� 5E        ButtonDashedInfo#���  6   $
��New*��5F      $��10,5,0,0q�5G      $��70��5H      $��Center=�5I      ��5J      �� *ClearEditCommand+5K      �� 5N      $��Amount��6   $
��Left=�6*   ���	#FF3E3E3E$��0,5,0,0q�6\   �� 5O      $	��250��6   $
��Left=�5Q      $��0,5,0,0q�5R      ��5P      �� *Amount+$ TwoWay=�5R      �� 5T      $��Payment Date��6   $
��Left=�60   ���	#FF3E3E3E6K     5U      $	��250��6   $
��Left=�5W      $��0,5,0,0q�5X       5V      �� *PaymentDate+$ TwoWay=�5X      �� 5[      $��Notes��6   $
��Left=�6)   ���	#FF3E3E3E$��0,5,0,0q�6[   �� 5\      $	��250��6   $
��Left=�5^      $��0,5,0,0q�5_       �� AcceptsReturn$
 True��5`       �� MinLines$ 4��5a      $��60��5b      ��5]      �� *Notes+$ TwoWay=�$ PropertyChanged=�5b      �� 5e      #���   6   $��Update Payment��5f      $��	0,25,10,0q�5g      $	��150��5h      $
��Left=�5i      y�5j      �� *IsEditButtonVisible+��5k      �� *UpdateCommand+�� 5m      #���   6   $��Add New Payment��5n      $��	0,25,10,0q�5o      $	��150��5p      $
��Left=�5q      y�5r      �� *IsAddButtonVisible+��5s      �� *
AddCommand+5t      5u      �� 5y   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   .+�5z      �� #���   6   $��← Back to Project��6=   $	��125��6Y   ��6e   �� *GotoAddProjectCommand+�� 5{      #���   6   $��Edit Project��6=   $	��125��6T   $��10,0,0,0q�6`   ��6r   �� *GoToEditCommand+�� 5|        ButtonDanger#���  6   $��Delete Payment��6<   $	��125��6U   $��10,0,0,0q�6a   ��6t   �� *DeleteCommand+5~      5      5�      