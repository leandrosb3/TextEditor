   M S B A M L   `   `   `  ����D  @Corrector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Corrector	Corrector  5   	       Corrector.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Corrector     5   	     � Title$  Editor de texto��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5   
   ]� $
��Left=�6   $��30��6/   ��.  $��10,0,0,0q�6Q   $	��Top=�6c   $	��774��6{   $��2��6�   .+�5      �� -   5         ��Name$ Abrir��5      $��	0,0,0,0.4q�6$   $��33��67   .��5      �� $�� Iconos/Nuevo.png��6    � ToolTip$ Nuevo��63   6E   5      � 5      .+�5      ��  �� ShowsPreview . $��5��63   $��Right=�6=   $��Stretch=�6Y   $��0,0,-0.2,0.4q�6u   5      �� 5      -   5        $ Guardar��5      $��	0,0,0,0.4q�6&   $��42��69   .��5      �� $��Iconos/guardar.png��6   $ Guardar��64   6H   5      � 5      .+�5      ��  . $��5��63   $��Right=�6=   $��Stretch=�6Y   5      �� 5!      -   5        $ Nuevo��5!      .��5"      �� $��Iconos/Abrir.png��6   $��42��62   $ Abrir��6=   5#      �� 5$      -   5        $ Imprimir��5$      $��	0,0,0,0.4q�6>   $��39��6Q   .��5%      �� $��Iconos/Printer.png��6   $ Imprimir��64   6I   5&      � 5(      $��	0,0,0,0.4q�6   $	��138��6&   .+�5)      ��  . $��5��63   $��Right=�6=   $��Stretch=�6Y   5*      �� 5-      -   5        $ AlinearIzquierda��5-      .��5/      �� $"�� Iconos/Aliear-izquierda.png��6   $ Alinear a la izquierda��6>   6a   50      � 52      .+�53      ��  . $��5��63   $��Right=�6=   $��Stretch=�6Y   54      �� 56      -   5        $ AlinearDerecha��56      $ Alinear a la derecha��6J   .��57      �� $ ��Iconos/Alinear-derecha.png��6   6>   58      � 5:      .+�5;      ��  . $��5��63   $��Right=�6=   $��Stretch=�6Y   5<      �� 5>      -   5        $ JustificarTexto��5>      $ Centralizar��6L   .��5?      �� $�� Iconos/Justificar.png��6   6:   5@      5B      �� 5E   
   -   5         ��Name$ NumeroTamaño��5E      $
��Left=�6)   $��	505,0,0,0q�6D   $	��Top=�6W   $��46��6o   $��30��6z    �� Text$  ��6�   6`  �� 5H   
   -	   5        $ Fuente��5H      $
��Left=�6#   $��	607,0,0,0q�6>   $	��Top=�6Q   $	��177��6i   $��30��6u   $ Arial��6�   6�   �� 5J   
   $��Tamaño��6   $
��Left=�6!   $��	432,4,0,0q�6<   $	��Top=�6O   �� 5M   
   $��Fuente��6   $
��Left=�6!   $��	556,4,0,0q�6<   $	��Top=�6O   �� 5Q   
    ��Language$ es�5T      -
   5         ��Name$ Editor��5Q      $
��Left=�6"   $	��275��6=   $��
31,115,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��723��6�   	 �� 	IsEnabled	 . ��5R      �� 
 �� ElementName$
 Letras����6<   �� $
 Fuente�� �� Path$ SelectedValue.Weight���5S      �� $
 Fuente��$ SelectedValue.Stretch���5T      �� $
 Fuente��$ SelectedValue.Style��� 5U   
   -   5        $ Letras��5U      $��21��6"   $��159,89,551.6,0q�6.   $
 Wrap=�6F   $�� ��6Z   $	��Top=�6b   �� 5V   
   $��Cantidad de letras��6   $
��Left=�6-   $��	32,89,0,0q�6H   $	��Top=�6[   5Y      5Z      