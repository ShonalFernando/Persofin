   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:PersofinDesktop.View.Transactions!PersofinDesktop.View.Transactions  5      8    2PersofinDesktop.View.Transactions.TransactionsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:PersofinDesktop.View.Transactions     5      S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5        N� Title$  TransactionsView��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��1* �6   �� 5      $��50 �6   .+�5   
   �� $��Transactions��6   $��10,10,10,10q�6(   $��36(�6=   $��Segoe UI Light)�6K   $��0��6g   $
��Left=�6t   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6/   .+�5      �� $ 
Horizontal=�6   $��	200,0,0,0q�62   .+�5      �� $��24(�69   $��
50,20,0,20q�6G   $	��100��6\   ��6   �� *TotalIncome+6\   �� 5      $��/Assets/Icons/upArrow.png��6   $��10q�6;   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��24(�6:   $��
50,20,0,20q�6H   $	��100��6]   ��6   �� *TotalExpense+6]   �� 5      $!��/Assets/Icons/downArrow.png��6   $��10q�6=   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5!      �� $	��100��6   $��	10,5,10,5q�6g   ��6#   �� *Years+ �� SelectedItem 6A   �� *SelectedYear+6g   �� 5$      $	��120��6   $��0,5,5,5q�6i   ��6#   �� *Months+ 6B   �� *SelectedMonth+6i   d� 5&      $��Show All��6   $��20,0,0,0q�6.   $��30��6@   $	��100��6L      ToggleButtonDefault#���   6�    d� 	IsChecked 6X   �� *ShowAllTransactions+ �� Mode$ TwoWay=�6�   5'      &   System.Windows.Controls.DataGrid  5)   
      AutoGenerateColumns$ False��5+         SelectionMode$ Single=�5,         
IsReadOnly$
 True��5-      $��2��5.      ��5)      �� *Transactions+ 5*      �� *SelectedTransaction+$ TwoWay=�	   Columns	 5/      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H      
Visibility$ Hidden=�6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6U     54      $

 Date��6%   $ * 6s    63   �� *DateOfRecord+ �� StringFormat$ {0:yyyy-MM-dd}��6s     57      $
 Category��6%   $ * 6T    67   �� *
Category+6T     5:      $

 Type��6%   $ * 6W    63   �� *TransactionType+6W     5=      $
 Amount��6%   $ * 6k    65   �� *Amount+$ 
{0:N2} LKR��6k     5@      $
 Description��6%   $ 2* 6Z    6:   �� *Description+6Z   5B      �� 5D   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   .+�5E      ��   ButtonPrimary#���  6   $��Add Transaction...��6=   $	��125��6Z   ��6f   �� *GotoAddTransactionCommand+�� 5F      #���  6   $��Edit Transaction...��6=   $	��125��6[   $��10,0,0,0q�6g   ��6y   �� *GotoEditTransactionCommand+�� 5G        ButtonDanger#���  6   $��Delete Transaction��6<   $	��125��6Y   $��10,0,0,0q�6e   ��6x   �� *DeleteTransactionCommand+5H      5I      5J      