   M S B A M L   `   `   `  ����
  Vistas    Vistas.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ txtCategoriaId��5      $	��100��6.   $��5q�6:   �� 5      -   5        $ 	txtNombre��5      $	��100��6)   $��5q�65   �� 5      -   5        $ 	txtPrecio��5      $	��100��6)   $��5q�65   �� 5      -   5        $ txtStock��5      $	��100��6(   $��5q�64   �� 5      -   5        $ txtUnidadMedida��5      $	��100��6/   $��5q�6;   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��5q�6X   .+�5      �� -   5        $��Agregar��5      $	��100��6'   $��5q�63   6>   �� 5      -   5        $��
Actualizar��5      $	��100��6*   $��5q�66   6A   �� 5      -   5        $��Eliminar��5      $	��100��6(   $��5q�64   6?   5      &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dataGrid��5      $��3��6%      AutoGenerateColumns . 62   5      5      