   M S B A M L   `   `   `  ����J  FPersofinDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PersofinDesktop.ViewPersofinDesktop.View  5   	   .    (PersofinDesktop.View.CreateAccountWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PersofinDesktop.View     5   	     � Title$  
AuthWindow��5   	   $	��768��6   $
��1366��6)    � WindowStyle$
 None=�66    � WindowState$ 	Maximized=�6I    � 
ResizeMode$ NoResize=�6a    � AllowsTransparency$
 True��6�   ��6w   Z� .��5	      � ���	#7FDCDCDC.+�5
   
   ��  �� CornerRadius$ 25,25,25,25��6   $
��1000��6,   $	��500��69    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$
 0.25Q�6#   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FFF1F1F1��6#   � 5      $
 	#FFE4E4E4��6#    � Offset$ 1Q�65   5      ._�5      �� $
��1000��6   $	��500��6&    �� Orientation$ 
Horizontal=�63   .+�5      �� $(��"/Assets/Backgrounds/AuthSplash.jpg��6   $	��500��6D   $	��500��6P   �� 5      .+�5      �� $��Create Account��6   $��48(�65   $��Segoe UI Semilight)�6C   $��	10,10,0,0q�6c   ���	#FF3173426v   �� 5      $��	10,10,0,0q�6!   �� 5      $��Username��6   $��	25,30,0,0q�6/   $��24(�6B   ���	#FF194E27$��Segoe UI Semilight)�6g   �� 5      $��25,5,0,0q�6   $	��350��60   ��6<   �� *
Username+�� 5      $��Password��6   $��	25,20,0,0q�6/   $��24(�6B   ���	#FF194E27$��Segoe UI Semilight)�6g   G� 5      -   5         G�Name$ PasswordInput��5   V   $��25,5,0,0q�6"   6V   �� 5      $��Create Account��6   $��	25,25,0,0q�66   $
��Left=�6I   ���	#B2D3F3D9$	��120��6{   ��6�   �� *CreateAccountCommand+�� 5       $��
25,120,0,0q�6!   �� 5!      $ 
Horizontal=�6!   $��25,5,0,0q�6:   .+�5"      �� $��Login��6!   $
��Left=�62   $	��120��6c   ��6M   Z� 6c   �� 5#      $
��Exit��6!   $��10,0,0,0q�60   $
��Left=�6C   $	��120��6t   ��6^   Z� ��6�   �� *ExitCommand+5$      5%      5&      5'      5)      5*      