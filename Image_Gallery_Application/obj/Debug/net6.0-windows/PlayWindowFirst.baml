   M S B A M L   `   `   `  ����T  PImage_Gallery_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Image_Gallery_ApplicationImage_Gallery_Application  5   	   /    )Image_Gallery_Application.PlayWindowFirst   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Image_Gallery_Application     5   	     � Title$  PlayWindowFirst��5   	   $	��750��6!   $
��1500��6.    � WindowStartupLocation$ CenterScreen=�6;   .��5	      � .+�5
   
   �� 
�������6&   �� 5   
    �� Orientation$ 
Horizontal=�6   $��150 20 0 20q�6.   .+�5      �� -   5        $��
Thumbnails��5      ��5      �� 5      .R�5      �� $	��250��63   $	��500��6@   $��5q�6M   $��Center=�6X   ��6    �� 6X   5      ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        5      5      5      �� 5   
   -   5        $��	ImageList��5      $��1200,10,10,10q�6$   ��5      �� 5      .R�5      �� $��20��61   $	��300��6=   $��5q�6I   ��6    �� 6I   5      5       �� 5!   
   -   5         ��Name$
 open��5!      $
��Open��6   $
��Left=�6.   $��512,347,0,0q�6I   $	��Top=�6^      
mainButton#��[  6�   
�������
���   �$��20(�6�   �� 5"   
   -   5        $ selectImage��5"      $��Select image��6&   $
��Left=�6=   $��925,342,0,0q�6X   $	��Top=�6m   #��[  6�   
�������
���   �$��20(�6�   �� 5#   
   -   5        $ delete��5#      $��delete��6!   $
��Left=�62   $��1270,600,0,0q�6M   $	��Top=�6c   #��[  6�   
�������
���   �$��10(�6�   �� 5$   
   -   5        $
 play��5$      $
��play��6   $
��Left=�6.   $��1270,670,0,0q�6I   $	��Top=�6_   #��[  6�   
�������
���   �$��10(�6�   �� 5%   
   -   5        $ other��5%   /   $��Open Another Folder��6   $
��Left=�6>   $��925,442,0,0q�6Y   $	��Top=�6n   #��[  6�   
�������
���   �$��15(�6�   �� 5&   
   -	   5        $ return��5&      $��
Go to Main��6!   $
��Left=�66   $��925,533,0,0q�6Q   $	��Top=�6f   #��[  6�   
�������
���   �$��20(�6�   5(      5)      