   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:PersofinDesktop.View.Pages.IncomeExpense(PersofinDesktop.View.Pages.IncomeExpense  5      =#clr-namespace:PersofinDesktop.ModelPersofinDesktop.Model  5      =    7PersofinDesktop.View.Pages.IncomeExpense.IncomeRegistry   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:PersofinDesktop.View.Pages.IncomeExpense     5      6models#clr-namespace:PersofinDesktop.Model     5        N� Title$  IncomeRegistry��5
      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Register Income��6   $��Segoe UI Semilight)�6*   $��28(�6J   �� 5   
   $��Received Date:��6   $��1��6*   $��	10,10,0,0q�67   (  "System.Windows.Controls.DatePicker  5   
   $��1��6@   $��	140,5,0,5q�6M   $	��250��6`      SelectedDate 6   �� *Date+ �� Mode$ TwoWay=�6`   �� 5   
   $��Received Type:��6   $��2��6*   $��	10,10,0,0q�67   �� 5    
   $��2��5!   F   $��	140,5,0,5q�6S   $	��250��6f   ��5       �� *RecievedType+ �� SelectedItem 5!      �� *RecievedType+$ TwoWay=�6f   �� 5#   
   $��Description:��6   $��3��6(   $��	10,10,0,0q�65   �� 5$   
   $��3��6<   $��	140,5,0,5q�6I   $	��250��6\   $
��Left=�6h   ��6   �� *Description+$ TwoWay=�6h   �� 5&   
   $��Amount Received:��6   $��4��6,   $��	10,10,0,0q�69   �� 5'   
   $��4��67   $��	140,5,0,5q�6D   $	��250��6W   $
��Left=�6c   ��6   �� *Amount+$ TwoWay=�6c   �� 5)   
   $��Payment Method:��6   $��5��6+   $��	10,10,0,0q�68   �� 5*   
   $��5��5+   G   $��	140,5,0,5q�6T   $	��250��6g   ��5*      �� *RecievedType+ 5+      �� *PaymentMethod+$ TwoWay=�6g   �� 5-   
   $��Payment Information:��6   $��6��60   $��	10,10,0,0q�6=   �� 5.   
   $��6��6/   $��	140,5,0,5q�6<   $	��250��6O   $	��100��6[   $
��Left=�6h    �� AcceptsReturn$
 True��6�   ��6   �� *PaymentInfo+6�   �� 5/   
   $��50��6   $	�� + ��6   $��6��6*   $��	400,5,0,5q�67   $��Bottom=�6J   �� 51   
   $��Received to Account:��6   $��7��60   $��	10,10,0,0q�6=   �� 52   
   $��7��53   K   $��	140,5,0,5q�6X   $	��250��6k   ��52      �� *RecievedToAccount+ 53      �� *RecievedToAccount+$ TwoWay=�6k   �� 55   
   $��Income Source:��6   $��8��6*   $��	10,10,0,0q�67   �� 56   
   $��8��57   F   $��	140,5,0,5q�6S   $	��250��6f   ��56      �� *IncomeSource+ 57      �� *IncomeSource+$ TwoWay=�6f   �� 59   
   $
��Save��6   $��9��6@   $
��Left=�6M   $��
240,10,0,0q�6h   $	��150��6|   ��6    �� *SaveCommand+6|   5:      5;      