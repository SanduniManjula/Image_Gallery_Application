   M S B A M L   `   `   `  ����T  PImage_Gallery_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Image_Gallery_ApplicationImage_Gallery_Application  5   	   ,    &Image_Gallery_Application.UploadWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Image_Gallery_Application     5   	     � Title$  UploadWindow��5   	   $	��750��6   $
��1500��6+    � WindowStartupLocation$ CenterScreen=�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� 
�������6   �� 5   
   
�������$��1��6(   �� 5   
   $��2��6   
�������._�5      �� -   5        $
��list��5      $��0,0,0,0q�6#   ��5      �� 5      .R�5      �� $��20��65   $	��300��6A   $��5q�6M   ��6$   �� 6M   5      5      5      �� 5   
   $$��Images/uploadWindowLayout.jfif��6   $��337,178,590,304q�68   �� 5   
   $��UPLOAD GOOGLE DRIVE��6   $��30(�6/    �� Padding$ 15q�6=   $
��Bold"�6J    �� TextAlignment$ Center=�6\   
�������
���   �$	��575��5   ,   $��67��68   $��136,431,415,203q�6D   �� 5   
   -   5        $
��open��5         
mainButton#��[  6   $��Open Files to Upload��6A   $��750,227,0,0q�6a   $	��Top=�6v   $	��200��6�   $
��Left=�6�   6�   �� 5   
   -   5         ��Name$ upload��5      #��[  6!   $��Upload List��6E   $
��Left=�6[   $��750,336,0,0q�6v   $	��200��6�   $	��Top=�6�   6�   �� 5   
   -   5        $ return��5      #��[  6!   $��
Go to Main��6E   $
��Left=�6Z   $��750,438,0,0q�6u   $	��200��6�   $	��Top=�6�   6�   5!      5"      