   M S B A M L   `   `   `  ����  WindowsAutomatedSimplifier>    8WindowsAutomatedSimplifier.IconSpacing.IconSpacingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	    � Title$ IconSpacingWindow��5	   	   $	��155��6#   $	��334��60   .��5
      � $��
10,10,10,0q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ContextMenu 5   
   �� 5      .@�5      m� -   5        $��Default��5   7   $��Restore to default��6   6F   m� 5      -   5        $��Reset��5   6   $��Reset last change��6   6D   5      .+�5   
   �� -   5         ��Name$ Vertical��5      $��	Vertical:��6"   $��0��66   $��0��6C   $��Right=�6S   �� 5   
   -   5         ��Name$ VSlider��5      $��0��6"   $��1��6/    � Minimum$	 480Q�6?   	 � Maximum$
	 2730Q�6M   
 � LargeChange$	
 100Q�6\    � SmallChange$ 10Q�6n    �� IsSnapToTickEnabled . 6   �� 5   
   -   5        $ 
Horizontal��5      $��Horizontal:��6$   $��1��6:   $��0��6G   $��Right=�6W   �� 5    
   -   5        $ HSlider��5       $��1��6"   $��1��6/   $	 480Q�6?   $
	 2730Q�6M   $	
 100Q�6\   $ 10Q�6n    . $	��180��6�   �� 5"   
   -   5         ��Name$ ApplyChangesBtn��5"      $��Change��6*   $��2��6[   $��0��6h   $��0,14,4,4q�6x   �� 5#   
   -   5        $ ResetSliderBtn��5#      $��ResetSlider��6)   $��1��6^   $��0,14,0,4q�6n   $��2��6�   $��80��6�   �� 5%   
   $��2��6?   $��0��6O   ��6   �� *Value+ �� ElementName$ VSlider��6O   �� 5&   
   $��2��6?   $��1��6O   ��6   �� *Value+$ HSlider��6O   5(      5)      