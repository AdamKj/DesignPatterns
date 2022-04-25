# Dependency Inversion Principle

### *Bero på abstraktion, inte konkretioner*

En hög hierarkisk klass ska inte behöva ärva av en låg hierarkisk klass, och vice versa.  
Klasser ska ej ärva konkreta detaljer, så som metoder, från andra klasser.  
De båda ska istället ärva av en typ av abstraktion, som te x. ett **Interface**.

#### Exempel
Om du har en klass som ärver av en annan klass och dens metoder. Så ska du istället ärva av antingen ett **Interface** eller en *Abstrakt klass*, och deras metoder.