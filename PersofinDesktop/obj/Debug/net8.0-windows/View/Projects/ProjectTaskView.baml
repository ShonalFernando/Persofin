   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersofinDesktop.View.ProjectsPersofinDesktop.View.Projects  5      U/clr-namespace:PersofinDesktop.View.UserControls!PersofinDesktop.View.UserControls  5      3    -PersofinDesktop.View.Projects.ProjectTaskView   5      S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:PersofinDesktop.View.Projects     5      IlocalControls/clr-namespace:PersofinDesktop.View.UserControls     5        N� Title$  ProjectTaskView��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��1* �6   �� 5      $��50 �6   .+�5   
   �� $��Project Resources��6   $��10,10,10,10q�6-   $��36(�6B   $��Segoe UI Light)�6P   $��0��6l   $
��Left=�6y   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5      �� $ 
Horizontal=�6    � ToolTip$K ECompleted Payments for completed projects for the selected date range��62   .+�5      �� $��24(�6G   $��
50,20,0,20q�6U   $	��100��6j   ��6   �� *ProjectsPaid+ �� Mode$ TwoWay=�6j   �� 5      $��/Assets/Icons/pay.png��6   $��10q�69   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5      �� $��18��6   $��10,0,0,0q�6$   ���	#3F9A9A9APayment Date6[   (  "System.Windows.Controls.DatePicker  5      $	��150��6   $��	10,5,10,5q�6}      SelectedDate 6%   �� *DateSelected+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6}   �� 5       $��	10,10,0,0q�6   ���	#3F9A9A9A---------------->6U   �� 5"      $��10,0,0,0q�6   $��30��6'   $	��120��63   $��Filter��6a      ButtonPrimary#���   6r   ��6?   �� *FilterCommand+6r   �� 5$      $��	10,10,0,0q�6   ���	#3F9A9A9A---- or ----6P   d� 5&      $��10,0,0,0q�6   $	��120��6-   $��Show All��6W     ToggleButtonPrimary#���  6j    d� 	IsChecked 69   �� *	ShowAll+6j   5'      � 5)   
   $��2��6    � ColumnDefinitions 5*      �� 5+      $	��11* �6#   �� 5,      $��3* �6#   .+�5/      2   ,PersofinDesktop.View.UserControls.GanntChart  $��0��6'   $��10q�54      	   Tasks	 50      �� *	MyTasks+
   ProjectStartDate
 51      �� *ProjectStart+   ProjectEndDate 52      �� *
ProjectEnd+   SelectedTask 53      �� *SelectedTask+54      �� 56      $��10q�6   $��1��6%   .+�57      �� $��
Payment ID��6   $
��Left=�6.   ���	#FF3E3E3E6I   �� 58      $ 
Horizontal=�6   .+�59      �� $	��170��6   $
��Left=�5:      $��0,5,0,0q�5;      ��5:   /   �� *	PaymentId+{�6J   �� *IDFieldEnabled+5;      �� 5<        ButtonDashedInfo#���  6   $
��New*��5=      $��10,5,0,0q�5>      $��70��5?      $��Center=�5@      ��5A      �� *ClearEditCommand+5B      �� 5E      $��Amount��6   $
��Left=�6*   ���	#FF3E3E3E$��0,5,0,0q�6\   �� 5F      $	��250��6   $
��Left=�5H   	   $��0,5,0,0q�5I   	   ��5G   	   �� *Amount+$ TwoWay=�5I   	   �� 5K      $��Payment Date��6   $
��Left=�60   ���	#FF3E3E3E6K     5L      $	��250��6   $
��Left=�5N      $��0,5,0,0q�5O       5M      �� *PaymentDate+$ TwoWay=�5O      �� 5R      $��Notes��6   $
��Left=�6)   ���	#FF3E3E3E$��0,5,0,0q�6[   �� 5S      $	��250��6   $
��Left=�5U   
   $��0,5,0,0q�5V   
    �� AcceptsReturn$
 True��5W   
    �� MinLines$ 4��5X   
   $��60��5Y   
   ��5T   
   �� *SelectedTask.Title+$ TwoWay=�$ PropertyChanged=�5Y   
   �� 5\      #���   6   $��Update Resource Data��5]   	   $��	0,25,10,0q�5^   	   $	��150��5_   	   $
��Left=�5`   	   y�5a   	   �� *IsEditButtonVisible+��5b   	   �� *UpdateCommand+�� 5d      #���   6   $��Add New Resource��5e   	   $��	0,25,10,0q�5f   	   $	��150��5g   	   $
��Left=�5h   	   y�5i   	   �� *IsAddButtonVisible+��5j   	   �� *
AddCommand+5k      5l      �� 5p   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   .+�5q      �� #���   6   $��← Back to Project��6=   $	��135��6Y   ��6e   �� *GotoAddProjectCommand+�� 5r      #���   6   $��Edit Resource Data��6=   $	��135��6Z   $��10,0,0,0q�6f   ��6x   �� *GoToEditCommand+�� 5s        ButtonDanger#���  6   $��Delete Resource Data��6<   $	��135��6[   $��10,0,0,0q�6g   ��6z   �� *DeleteCommand+5t      5u      5v      