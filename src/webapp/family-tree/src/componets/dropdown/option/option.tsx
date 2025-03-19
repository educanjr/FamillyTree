import styles from './option.module.css';

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
    children: React.ReactNode;
    isSelected: boolean;
    isPreselected: boolean;
}

export default function Option({ children, isSelected = false, isPreselected = false, ...props }: ButtonProps) {
    return (
        <button className={`${styles['dropdown-option']} ${isSelected ? styles['selected'] : ''}  ${isPreselected ? styles['preselected'] : ''}`} {...props}>
            {children}
        </button>
    );
}