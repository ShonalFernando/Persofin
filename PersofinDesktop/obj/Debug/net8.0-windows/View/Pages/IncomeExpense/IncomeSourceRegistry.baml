   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:PersofinDesktop.View.Pages.IncomeExpense(PersofinDesktop.View.Pages.IncomeExpense  5      C    =PersofinDesktop.View.Pages.IncomeExpense.IncomeSourceRegistry   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:PersofinDesktop.View.Pages.IncomeExpense     5        N� Title$  IncomeSourceRegistry��5	      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Register Income Source��6   $��Segoe UI Semilight)�61   $��28(�6Q   $��0��6_   �� 5   
   $��Income Source Name:��6   $��1��6/   $��	10,10,0,0q�6<   �� 5   
   $��1��65   $��	140,5,0,5q�6B   $	��250��6U   $
��Left=�6a   ��6   �� *Name+ �� Mode$ TwoWay=�6a   �� 5   
   $��Income Type:��6   $��2��6(   $��	10,10,0,0q�65   �� 5    
   $��2��5"      $��	140,5,0,5q�6    $	��250��63   ��5       �� *IncomeTypes+ �� SelectedItem 5!      �� *
IncomeType+$ TwoWay=�5"   3   �� 5$   
   $��Expected Amount:��6   $��3��6,   $��	10,10,0,0q�69   �� 5%   
   $��3��6?   $��	140,5,0,5q�6L   $	��250��6_   $
��Left=�6k   ��6   �� *ExpectedAmount+$ TwoWay=�6k   �� 5'   
   $��Contact Person:��6   $��4��6+   $��	10,10,0,0q�68   �� 5(   
   $��4��6>   $��	140,5,0,5q�6K   $	��250��6^   $
��Left=�6j   ��6   �� *ContactPerson+$ TwoWay=�6j   �� 5*   
   $��Contact Email:��6   $��5��6*   $��	10,10,0,0q�67   �� 5+   
   $��5��6=   $��	140,5,0,5q�6J   $	��250��6]   $
��Left=�6i   ��6   �� *ContactEmail+$ TwoWay=�6i   �� 5-   
   $��Contact Phone:��6   $��6��6*   $��	10,10,0,0q�67   �� 5.   
   $��6��6=   $��	140,5,0,5q�6J   $	��250��6]   $
��Left=�6i   ��6   �� *ContactPhone+$ TwoWay=�6i   �� 50   
   $��Payment Frequency:��6   $��7��6.   $��	10,10,0,0q�6;   �� 51   
   $��7��53      $��	140,5,0,5q�6    $	��250��63   ��51      �� *PaymentFrequencies+ 52      �� *PaymentFrequency+$ TwoWay=�53   3   �� 55   
   $��Additional Notes:��6   $��8��6-   $��	10,10,0,0q�6:   �� 56   
   $��8��66   $��	140,5,0,5q�6C   $	��250��6V    �� AcceptsReturn$
 True��6b   $��60��6w   $
��Left=�6�   ��6   �� *Notes+$ TwoWay=�6�   �� 58   
   $��Attached Bank Account:��6   $��9��62   $��	10,10,0,0q�6?   �� 59   
   $��9��5;      $��	140,5,0,5q�6    $	��250��63   ��59      �� *BankAccounts+ 5:      �� *AccountAttached+$ TwoWay=�5;   3   �� 5=   
   $
��Save��6   $��10��6@   $
��Left=�6N   $��
240,10,0,0q�6i   $	��150��6}   ��6    �� *SaveCommand+6}   5>      5?      