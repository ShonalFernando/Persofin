   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersofinDesktop.View.ProjectsPersofinDesktop.View.Projects  5   	   5    /PersofinDesktop.View.Projects.EditProjectWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:PersofinDesktop.View.Projects     5   	     � Title$  EditProjectWindow��5   	   $	��680��6$   $	��560��61    � 
ResizeMode$ NoResize=�6=    � ShowInTaskbar$ False��6S   .��5	      �� .��5
   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $��Starting Date��6    $
��Left=�65   ���	#FF3E3E3E6P   (  "System.Windows.Controls.DatePicker  5      $	��250��6!   $
��Left=�5      $��0,5,0,0q�5         SelectedDate 5      �� *	DateStart+ �� Mode$ TwoWay=�5      5      �� 5      $��20,0,0,0q�6   .+�5      �� $��Ending Date��6    $
��Left=�63   ���	#FF3E3E3E6N     5      $	��250��6!   $
��Left=�5      $��0,5,0,0q�5       5      �� *	DateEnd+$ TwoWay=�5      5      5      �� 5      $��Total Budget��6   $
��Left=�6,   ���	#FF3E3E3E$��0,15,0,0q�6^   �� 5       $	��250��6   $
��Left=�5"      $��0,5,0,0q�5#      ��5!      �� *TotalBudget+$ TwoWay=�5#      �� 5%      $��Title��6   $
��Left=�6%   ���	#FF3E3E3E$��0,15,0,0q�6W   �� 5&      $	��250��6   $
��Left=�5(      $��0,5,0,0q�5)      ��5'      �� *Title+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5)      �� 5,      $��Category��6   $
��Left=�6(   ���	#FF3E3E3E$��0,15,0,0q�6Z   �� 5-      $	��250��6   $
��Left=�50      $��0,5,0,0q�51      ��5.      �� *
Categories+ �� SelectedItem 5/      �� *
Category+$ TwoWay=�51      �� 53      $��Buget Information��6   $
��Left=�61   ���	#FF3E3E3E$��0,15,0,0q�6c   �� 54      $	��250��6   $
��Left=�56      $��0,5,0,0q�57       �� AcceptsReturn$
 True��58      	 �� MinLines$	 3��59      $��60��5:      ��55      �� *
BudgetInfo+$ TwoWay=�$ PropertyChanged=�5:      �� 5<      $ 
Horizontal=�6   .+�5=      �� .+�5>      �� $��Requirements��6    $
��Left=�64   ���	#FF3E3E3E$��0,15,0,0q�6f   �� 5?      $	��250��6   $
��Left=�5A      $��0,5,0,0q�5B      $
 True��5C      $��60��5D      $	 3��5E      ��5@      �� *Requirements+$ TwoWay=�$ PropertyChanged=�5E      5F      �� 5I      $��20,0,0,0q�6   .+�5J      �� $��Project Breakdown��6    $
��Left=�69   ���	#FF3E3E3E$��0,15,0,0q�6k   �� 5K      $	��250��6   $
��Left=�5M      $��0,5,0,0q�5N      $
 True��5O      $	 3��5P      $��60��5Q      ��5L      �� *Amount+$ TwoWay=�$ PropertyChanged=�5Q      5R      5S      �� 5V      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5W      �� .+�5X      �� $��Progress��6    $
��Left=�60   ���	#FF3E3E3E6K   �� 5Y      $	��250��6   $
��Left=�5[      $��0,5,0,0q�5\      $
 True��5]      $	 3��5^      $��60��5_      ��5Z      �� *
Progress+$ TwoWay=�$ PropertyChanged=�5_      5`      �� 5c      $��20,0,0,0q�6   .+�5d      �� $��Status��6    $
��Left=�6.   ���	#FF3E3E3E6I   �� 5e      $	��250��6   $
��Left=�5h      $��0,5,0,0q�5i      ��5f      �� *ProjectStatuses+ 5g      �� *ProjectStatus+$ TwoWay=�5i      5j      5k      �� 5n      $��0,10,0,0q�6   ���	#FFAF1212��6A   �� *ValidationMessage+�� 5p         ButtonPrimary#���   6   $��Update Transaction��5q      $��	0,25,10,0q�5r      $
��Left=�5s      ��5t      �� *EditProjectCommand+5u      5v      5w      