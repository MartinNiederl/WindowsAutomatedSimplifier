   M S B A M L   `   `   `  ����  WindowsAutomatedSimplifier:    4WindowsAutomatedSimplifier.DeCompress.CompressWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Compress��5   	   $	��190��6   $	��300��6'    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      � $��0,18,0,0q�6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��148 �6   �� 5      $	��148 �6   .+�5   
   �� -   5         ��Name$
 Path��5      $��C://temp��6    $��0��60   $��0��6=   $��	10,0,0,10q�6N   $��20��6a    �� TextAlignment$ Center=�6m   �� 5   
   -   5        $ Filename��5      $��filename��6$   $��0��64   $��1��6A   $��
10,0,10,10q�6Q   $��20��6e   $ Center=�6q   �� 5   
   -   5         ��Name$ LblArchiveFormat��5      $��Archive Format:��6*   $��1��6D   $��0��6Q   $��Right=�6a   �� 5   
   -   5         ��Name$ 
CobArchive��5      	 �� SelectedIndex$	 0��6'   $	��120��6i   $��1��6u   $��1��6�   $	��0,2q�6�   �� 5   
   -   5        $ LblCompressionFormat��5      $��Compression Format:��6.   $��2��6L   $��0��6Y   $��Right=�6i   �� 5   
   -   5        $ CobCompress��5      $	 0��6(   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6:   $	��120��6_   $��2��6k   $��1��6x   $	��0,2q�6�   �� 5   
   -   5         ��Name$ Button��5      $��Compress��6!   $
��Bold"�6I   $��24��6[   $��80��6g   $��3��6r   $��1��6   $��0,12,0,0q�6�   5      5      