   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:PersofinDesktop.View.Transactions!PersofinDesktop.View.Transactions  5   	   <    6PersofinDesktop.View.Transactions.AddTransactionWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:PersofinDesktop.View.Transactions     5   	     � Title$  Add Transaction��5   	   $	��420��6!   $	��400��6.    � 
ResizeMode$ NoResize=�6:    � ShowInTaskbar$ False��6P   .��5	      �� $��10q�6   .+�5
   
   �� $��Date of Transaction��6   $
��Left=�6/   ���	#FF3E3E3E6J   (  "System.Windows.Controls.DatePicker  5   
   $	��250��6   $
��Left=�5      $��0,5,0,0q�5         SelectedDate 5      �� *DateOfTransaction+ �� Mode$ TwoWay=�5      �� 5   
   $��Description��6   $
��Left=�6'   ���	#FF3E3E3E$��0,15,0,0q�6Y   �� 5   
   $	��250��6   $
��Left=�5      $��0,5,0,0q�5      ��5      �� *Description+$ TwoWay=�5      �� 5   
   $��Amount��6   $
��Left=�6"   ���	#FF3E3E3E$��0,15,0,0q�6T   �� 5   
   $	��250��6   $
��Left=�5      $��0,5,0,0q�5      ��5      �� *Amount+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��Transaction Type��6   $
��Left=�6,   ���	#FF3E3E3E$��0,15,0,0q�6^   �� 5   
   $	��250��6   $
��Left=�5       $��0,5,0,0q�5!      ��5      �� *TransactionTypes+ �� SelectedItem 5      �� *TransactionType+$ TwoWay=�5!      �� 5#   
   $��Category��6   $
��Left=�6$   ���	#FF3E3E3E$��0,15,0,0q�6V   �� 5$   
   $	��250��6   $
��Left=�5'      $��0,5,0,0q�5(      ��5%      �� *
Categories+ 5&      �� *
Category+$ TwoWay=�5(      �� 5*   
      ButtonPrimary#���   6   $��Add Transaction��5+      $��	0,25,10,0q�5,      $
��Left=�5-      ��5.      �� *AddTransactionCommand+5/      50      