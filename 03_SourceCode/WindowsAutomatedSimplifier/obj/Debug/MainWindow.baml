   M S B A M L   `   `   `  ����  WindowsAutomatedSimplifier+    %WindowsAutomatedSimplifier.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$" Windows Automated Simplifier��5   	   $	��300��6.   $	��304��6;   .��5	      �  � RowDefinitions 5
   
   �� 5      $��24 �6   �� 5      $��24 �6   �� 5      $��24 �6   �� 5      $��24 �6   �� 5      $��14 �6   �� 5      $��24 �6   �� 5      $��14 �6   �� 5      $��24 �6   �� 5      $��24 �6   �� 5      $��24 �6    � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��120 �6   �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ BtnCompress��5      $��Compress��6&   $��0��6V   $��2q�6c   �� 5   
   -   5        $ BtnDecompress��5      $��
Decompress��6(   $��0��6\   $��2��6i   $��2q�6y   �� 5   
   -   5        $ BtnIconSpacing��5      $��IconSpacing��6)   $��1��6^   $��1��6k   $��2q�6{   �� 5   
   -   5        $ BtnCreateProtectedFolder��5      $��	CreatePWF��63   $��0��6G   $��2��6W   $��2q�6d   6o   �� 5   
   -   5        $ BtnReadProtectedFolder��5      $��ReadPWF��61   $��2��6C   $��2��6S   $��2q�6`   6k   �� 5    
   -   5        $ BtnDeleteEmptyFolders��5       $��DeleteEmptyFolders��60   $��1��6M   $��3��6]   $��2q�6j   6u   �� 5"   
   -   5         ��Name$ 
MSecSlider��5"      $��2q�6%    � Maximum$	 100Q�60    � Value$	 100Q�6>    � SmallChange$ 1Q�6J   	 �� IsSnapToTickEnabled	 . $��5��6u   $��0��6�   �� 5#   
   -   5        
 ��Name$
 MSecView��5#      $��5��6j   $��1��6w   ��6"   �� *Value+ �� ElementName$ 
MSecSlider�� �� StringFormat$ {0}ms��6w   �� 5$   
   -	   5        $ BtnSetAeroSpeed��5$      $��Activate��6*   $��2q�6=   $��5��6H   $��2��6U   6e   �� 5&   
   -
   5        $ BtnActivateSCExtension��5&      $��Activate��61   $��7��6X   $��0��6e   $��2q�6u   �� 5'   
   -   5        $ BtnDeactivateSCExtension��5'      $��
Deactivate��63   $��7��6\   $��2��6i   $��2q�6y   �� 5)   
   -   5        $ UpdateRegistry��5)      $��SaveChanges��6)   $��8��6?   $��1��6L   $��2q�6\   6g   �� 5*   
   -   5        $ 
FontChange��5*      $��
ChangeFont��6%   $��0��6:   $��2q�6J   $��9��6U   6b   �� 5+   
   -   5        $ BtnImage��5+      $��Button��6#   $��2��64   $��9��6D   $��2q�6Q   6\   5,      5.      