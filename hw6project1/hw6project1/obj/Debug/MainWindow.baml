   M S B A M L   `   `   `  ����F  Bhw6project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:hw6project1hw6project1  5   	       hw6project1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:hw6project1     5   	     � Title$  Counter Driver��5   	   $	��350��6    $	��525��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ createCounterButton��5
      $��Toggle Counter��6.   $
��Left=�6G   $��	27,34,0,0q�6b   $	��Top=�6u   $	��129��6�   6�   �� 5   
   -   5        $ setCounterButton��5      $��Set Counter to :��6+   $
��Left=�6F   $��	27,81,0,0q�6a   $	��Top=�6t   $	��129��6�   {�.  6�   �� 5   
   -   5        $ getCounterButton��5      $��Get Counter :��6+   $
��Left=�6C   $��
27,108,0,0q�6^   $	��Top=�6r   $	��129��6�   {�.  6�   �� 5   
   -   5        $ incrementCounterButton��5      $��Increment Counter��61   $
��Left=�6M   $��
27,135,0,0q�6h   $	��Top=�6|   $	��129��6�   {�.  6�   �� 5   
   -   5        $ decrementCounterButton��5      $��Decrement Counter��61   $
��Left=�6M   $��
27,162,0,0q�6h   $	��Top=�6|   $	��129��6�   {�.  6�   �� 5   
   -   5        $ displayCounterButton��5      $��Counter to Console��6/   $
��Left=�6L   $��
27,188,0,0q�6g   $	��Top=�6{   $	��129��6�   {�.  6�   �� 5   
   -   5        $ equalsCounterButton��5      $��Equal Counters Test��6.   $
��Left=�6L   $��
27,215,0,0q�6g   $	��Top=�6{   $	��129��6�   {�.  6�   �� 5   
   -   5         ��Name$ counterLabel��5      $��	Counter: ��6&   $
��Left=�6:   $��
323,31,0,0q�6U   $	��Top=�6i   {�.  6�   �� 5   
   -	   5         ��Name$ emptyTextBlock��5      $
��Left=�6,   $��
395,36,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   {�.  $��0��6�   �� 5   
   -
   5         ��Name$ setCounterBox��5      $
��Left=�6)   $��22��6D   $��
177,81,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $��59��6�   {�.  6�   �� 5   
   -   5        $ getCounterBox��5      $
��Left=�6)   $��22��6D   $��177,108,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $��59��6�   {�.  6�   �� 5   
   -   5        $ incrementBox��5      $
��Left=�6(   $��22��6C   $��177,135,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $��59��6�   {�.  6�   �� 5   
   -   5        $ decrementBox��5      $
��Left=�6(   $��22��6C   $��177,162,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $��59��6�   {�.  6�   �� 5   
   -   5        $ 	equalsBox��5      $
��Left=�6%   $��22��6@   $��177,214,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��59��6�   {�.  6�   �� 5   
   -   5        $ 
booleanBox��5      $
��Left=�6(   $��255,215,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   {�.  $��46��6�   $��21��6�   �� 5   
   -   5        $ decrementBoxOutput��5      $
��Left=�60   $��255,162,0,0q�6K   $
��Wrap=�6`   $	��Top=�6t   {�.  $��46��6�   $��22��6�   �� 5   
   -   5        $ incrementBoxOutput��5      $
��Left=�60   $��255,135,0,0q�6K   $
��Wrap=�6`   $	��Top=�6t   {�.  $��46��6�   $��21��6�   5      5      