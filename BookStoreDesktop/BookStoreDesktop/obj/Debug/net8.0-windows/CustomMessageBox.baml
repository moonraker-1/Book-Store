   M S B A M L   `   `   `  ����K  GBookStoreDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreDesktopBookStoreDesktop  5   	   '    !BookStoreDesktop.CustomMessageBox   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BookStoreDesktop     5   	     � Title$  CustomMessageBox��5   	   $	��180��6"   $	��300��6/   .��5	      � $	��180��6   .+�5
   
   �� -   5         ��Name$ btnSave��5
      $
��Save��6"   $
��Left=�61   $��
81,116,0,0q�6L   $��5,0,5,0q�6`   $	��Top=�6r   $��25��6�   $��47��6�   �� 5   
   -   5        $ 	btnNoSave��5      $��
Don't Save��6$   $
��Left=�69   $��141,116,0,0q�6T   $��5,0,5,0q�6i   $	��Top=�6{   $��25��6�   $��73��6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��228,116,0,0q�6P   $��5,0,5,0q�6e   $	��Top=�6w   $��25��6�   $��53��6�   �� 5   
   -   5         ��Name$ messageLabel��5      $��Label��6&   $��Center=�66   $��0,24,0,0q�6S   $	��Top=�6e   $��58��6}   $	��280��6�   5      5      